import numpy as np
import tensorflow as tf
import matplotlib.pyplot as plt
import sklearn.datasets as ds
from sklearn.metrics import roc_curve, auc
from matplotlib.colors import ListedColormap
from scipy.interpolate import spline



#======================= global variables
learning_rate = 0.002
training_epochs = 10000
display_step = 100
n_samples = 1000
n_noise = .5
n_layers = [2, 1]
steps = []
train_accs = []
test_accs = []


#======================= load data
def logistic_model(input, layers):
    i = 1
    a = input
    n_input = int(a.get_shape()[1])
    for n_perceptron in layers:
        W = tf.Variable(tf.truncated_normal([n_input, n_perceptron]), name='w' + str(i))
        b = tf.Variable(tf.zeros([n_perceptron]), name='b' + str(i))
        z = tf.matmul(a, W) + b
        a = tf.nn.sigmoid(z)
        n_input = n_perceptron
        i = i + 1
    return a


tf_X = tf.placeholder(tf.float32, [None, 2])       # 2 input features
tf_y = tf.placeholder(tf.float32, [None, 1])       # binary output
tf_output = logistic_model(tf_X, n_layers)

tf_cost = tf.reduce_sum(-tf.log(tf_output * tf_y + (1 - tf_output) * (1 - tf_y))) 
tf_train = tf.train.GradientDescentOptimizer(learning_rate).minimize(tf_cost)

tf_predict = tf.cast(tf.greater(tf_output, 0.5), tf.float32)
tf_accuracy = tf.reduce_mean(tf.cast(tf.equal(tf_predict, tf_y), tf.float32))
x_data, y_data = ds.make_moons(n_samples=n_samples, shuffle=True, noise=n_noise)
  
for l in np.arange(100, 1000, 10):
    n_training_size = int(l * .6)
    print(n_training_size)
    steps.append(n_training_size)
    train_acc = 0
    test_acc = 0
    mc = 5
    with tf.Session() as sess:
        sess.run(tf.global_variables_initializer())
        for j in range(1, mc + 1):
            x_train, y_train = x_data[:n_training_size], y_data[:n_training_size][:,None]
            x_test, y_test = x_data[n_training_size:], y_data[n_training_size:][:,None]

            for epoch in range(training_epochs):
                train_output, t_acc = sess.run([tf_train, tf_accuracy], feed_dict={tf_X:x_train, tf_y:y_train})
            
            train_acc += t_acc
            print(train_acc, t_acc)
            test_acc += sess.run(tf_accuracy, feed_dict={tf_X: x_test, tf_y: y_test})

    print(np.round(train_acc * 100 / mc, 2))
    train_accs.append(np.round(train_acc * 100 / mc, 2))
    test_accs.append(np.round(test_acc * 100 / mc, 2))


xnew = np.linspace(np.min(steps),np.max(steps), 300)
train_accs = spline(np.array(steps), np.array(train_accs), xnew)
test_accs = spline(np.array(steps), np.array(test_accs), xnew)

plt.plot(xnew, np.c_[train_accs, test_accs])
plt.xlabel('Number of training examples')
plt.legend(['Train Accuracy', 'Test Accuracy'])
plt.title(str(n_layers))
plt.show()