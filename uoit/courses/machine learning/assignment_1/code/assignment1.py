import numpy as np
import scipy as sc
import matplotlib.pyplot as plt
import sklearn as sklearn
import sklearn.datasets as ds
from sklearn.preprocessing import PolynomialFeatures
from scipy.interpolate import UnivariateSpline
from sklearn.model_selection import KFold



def init(shuffle=True, order=1):
    dataset = ds.fetch_california_housing()
    X, y = dataset.data, dataset.target

    # shuffle data
    if(shuffle):
        X, y = sklearn.utils.shuffle(X, y) 

    # higher orders
    if(order > 1):
        poly = PolynomialFeatures(order)
        X = poly.fit_transform(X)
    
    # whiten data
    X = sc.linalg.inv(sc.linalg.sqrtm(X.T.dot(X))).dot(X.T).T   
    a = np.var(X, axis = 0)

    # add intercept column
    X = np.c_[[1] * X.shape[0], X]                              

    plotA(X, y, dataset.feature_names)
    plotB(X, y, 0.8)
    
    fit_polynomial_features(dataset.data, y, [4], 1000, 3, 0)



def estimate_theta(X, y, d2):
    m = X.shape[0]              # number of training example
    n = X.shape[1]              # number of feaures

    reg = d2 * np.eye(n)        # regularization
    reg[0, 0] = 0               # don't regularize bias

    theta = np.linalg.inv(X.T.dot(X) + reg).dot(X.T.dot(y))
    return theta[:, np.newaxis]



def plotA(X, y, names):
    thetas = []
    regs = np.logspace(-7, -1, 200)
    for reg in regs:
        theta = estimate_theta(X, y, reg).ravel()
        thetas.append(theta)

    plt.plot(regs, thetas)
    plt.xscale('log')
    plt.xlabel('Regularization ${\delta}^2$')
    plt.ylabel('Values of ${\Theta}$s')
    plt.legend(['bias', *names])
    plt.title('Ridge coefficients as a function of the regularization')
    plt.xlim(regs.min(), regs.max())
    plt.show()
    


def plotB(X, y, per):
    errors = []
    regs = np.logspace(-7, 3, 100)
    n = int(per * y.size)
    X_train, X_test = X[:n,:], X[n:,:]
    y_train, y_test = y[:n], y[n:]
    thetas = np.empty((X.shape[1], 0))

    for reg in regs:
        theta = estimate_theta(X_train, y_train, reg)
        thetas = np.hstack((thetas, theta))

    train_error = np.average((y_train - thetas.T.dot(X_train.T)) ** 2, axis = 1)
    test_error = np.average((y_test - thetas.T.dot(X_test.T)) ** 2, axis = 1)

    errors = np.c_[train_error, test_error]
    ax = plt.gca()

    plt.plot(regs, errors)
    plt.xscale('log')
    plt.xlabel('Regularization ${\delta}^2$')
    plt.ylabel('Error')
    plt.legend(['train error', 'test error'])
    plt.title('Comparison of test and train error for diﬀerent values of the regularization')
    plt.xlim(regs.min(), regs.max())
    plt.show()



def plotB_5fold(X, y, per):
    errors = []
    regs = np.logspace(-7, 3, 100)
    n = int(per * y.size)
    X_train, X_test = X[:n,:], X[n:,:]
    y_train, y_test = y[:n], y[n:]
    kf = KFold(5)

    train_error = 0
    test_error = 0
    for train_index, test_index in kf.split(X):
        X_train, X_test = X[train_index], X[test_index]
        y_train, y_test = y[train_index], y[test_index]
        thetas = np.empty((X.shape[1], 0))
        for reg in regs:
            theta = estimate_theta(X_train, y_train, reg)
            thetas = np.hstack((thetas, theta))

        train_error = train_error + np.average((y_train - thetas.T.dot(X_train.T)) ** 2, axis = 1)
        test_error = test_error + np.average((y_test - thetas.T.dot(X_test.T)) ** 2, axis = 1)

    errors = np.c_[train_error / 5, test_error / 5]
    ax = plt.gca()

    plt.plot(regs, errors)
    plt.xscale('log')
    plt.xlabel('Regularization ${\delta}^2$')
    plt.ylabel('Error')
    plt.legend(['train error', 'test error'])
    plt.title('Comparison of test and train error for diﬀerent values of the regularization, using 5 fold cross validation')
    plt.xlim(regs.min(), regs.max())
    plt.show()



def fit_polynomial_features(X, y, features, n, degree, d2):
    X = X[:n, features]
    y = y[:n]
    poly = PolynomialFeatures(degree)

    x_p = poly.fit_transform(X)
    theta = estimate_theta(x_p, y, d2)
    predict = x_p.dot(theta)

    spl = UnivariateSpline(X, predict)
    xs = np.linspace(X.min(),X.max(),300)

    plt.plot(X,y,'.')
    plt.plot(xs,spl(xs))
    plt.xlabel('X')
    plt.ylabel('Y')
    plt.show()



init(True, 1)
