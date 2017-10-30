import tensorflow as tf

n_input = 2
n_neurons = 2     
learning_rate = 0.002

X = tf.placeholder(tf.float32, [None, n_input])     # network input
y = tf.placeholder(tf.float32, [None, 1])           # network output

# hidden layer
W1 = tf.Variable(tf.truncated_normal([n_input, n_neurons]), name='W1')
b1 = tf.Variable(tf.zeros([n_neurons]), name='b1')
z1 = tf.matmul(X, W1) + b1
a1 = tf.nn.sigmoid(z1)

# output layer
W2 = tf.Variable(tf.truncated_normal([n_neurons, 1]), name='W2')
b2 = tf.Variable(tf.zeros([1]), name='b2')
z2 = tf.matmul(a1, W2) + b2
a2 = tf.nn.sigmoid(z2)

y_pred = a2


cost = tf.reduce_sum(-tf.log(y_pred * y + (1 - y_pred) * (1 - y)))
train = tf.train.GradientDescentOptimizer(learning_rate).minimize(cost)

prediction = tf.cast(tf.greater(y_pred, 0.5), tf.float32)
accuracy = 1 - tf.reduce_mean(prediction - y)