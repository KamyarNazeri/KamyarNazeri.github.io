import numpy as np
import tensorflow as tf
import matplotlib.pyplot as plt
import sklearn.datasets as ds
from sklearn.metrics import roc_curve, auc
from matplotlib.colors import ListedColormap



#======================= global variables
learning_rate = 0.002
training_epochs = 10000
display_step = 100
n_samples = 1000
n_training_size = int(n_samples * .6)
n_noise = .1
n_layers = [2, 1]


#======================= load data
x_data, y_data = ds.make_moons(n_samples=n_samples, shuffle=True, noise=n_noise, random_state=666)
x_train, y_train = x_data[:n_training_size], y_data[:n_training_size][:,None]
x_test, y_test = x_data[n_training_size:], y_data[n_training_size:][:,None]
x1_min, x1_max = x_data[:, 0].min() - 1, x_data[:, 0].max() + 1
x2_min, x2_max = x_data[:, 1].min() - 1, x_data[:, 1].max() + 1
x1_eval, x2_eval = np.meshgrid(np.arange(x1_min, x1_max, .02), np.arange(x2_min, x2_max, .02))
x_eval = np.c_[x1_eval.ravel(), x2_eval.ravel()]
y_eval = np.zeros((x_eval.shape[1], 1))


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


#======================= design a network
tf_X = tf.placeholder(tf.float32, [None, 2])       # 2 input features
tf_y = tf.placeholder(tf.float32, [None, 1])       # binary output
tf_output = logistic_model(tf_X, n_layers)

tf_cost = tf.reduce_sum(-tf.log(tf_output * tf_y + (1 - tf_output) * (1 - tf_y))) 
tf_train = tf.train.GradientDescentOptimizer(learning_rate).minimize(tf_cost)

tf_predict = tf.cast(tf.greater(tf_output, 0.5), tf.float32)
tf_accuracy = tf.reduce_mean(tf.cast(tf.equal(tf_predict, tf_y), tf.float32))


#======================= train the network
with tf.Session() as sess:
    sess.run(tf.global_variables_initializer())
    writer = tf.summary.FileWriter('logs', sess.graph)

    for epoch in range(training_epochs):
        train_output, train_loss, train_acc = sess.run([tf_train, tf_cost, tf_accuracy], feed_dict={tf_X:x_train, tf_y:y_train})
            
        writer.add_summary(train_output, epoch)

        if (epoch + 1) % display_step == 0:
            print("Epoch: " + str(epoch + 1) + "\tLoss: " + str(train_loss) + "\tTrain Accuracy: " + str(np.round(train_acc * 100, 2)) + "%")

    test_output, test_acc = sess.run([tf_output, tf_accuracy], feed_dict={tf_X: x_test, tf_y: y_test})
    print("Accuracy on Test Set: " + str(np.round(test_acc * 100, 2)) + "%")

    eval_pred = sess.run([tf_predict], feed_dict={tf_X: x_eval, tf_y: y_eval})

    y_pred = np.array(test_output)
    y_eval = np.array(eval_pred).reshape(x1_eval.shape)



#======================= process evaluation
plt.figure()
plt.pcolormesh(x1_eval, x2_eval, y_eval, cmap=ListedColormap(['#FFAAAA', '#AAAAFF']))
plt.scatter(x_data[:,0], x_data[:,1], c=y_data, cmap=ListedColormap(['#FF0000', '#0000FF']))
plt.title('Binary Classification')
plt.show()


#======================= process ROC
fpr, tpr, _ = roc_curve(y_test, y_pred)
plt.figure()
plt.plot(fpr, tpr, color='darkorange',lw=2, label='ROC curve (area = %0.2f)' % auc(fpr, tpr))
plt.plot([0, 1], [0, 1], color='navy', lw=2, linestyle='--')
plt.xlim([0.0, 1.0])
plt.ylim([0.0, 1.05])
plt.xlabel('False Positive Rate')
plt.ylabel('True Positive Rate')
plt.title('Receiver Operating Characteristic')
plt.legend(loc="lower right")
plt.show()