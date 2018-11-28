import numpy as np
import cv2 as cv
import os
import tensorflow as tf
from tensorflow import keras
from sklearn.model_selection import train_test_split

# path = "/Users/qwerty/Downloads/pokemon/main-sprites/red-blue/"
path = "/Users/qwerty/Downloads/data/"
# len(t) = 105
# len(t1) = 2
# len(t2) = 128*128*3
x = []
x = []
y = []
j = 0
files = []
for i, filename in enumerate(os.listdir(path)):
    if filename[-4:] == ".png":
        files.append(filename)
files.sort()
print(files)
'''
for i, filename in enumerate(files):
    if i % 2 == 0:
        int_array = []
    b = bytearray(cv.imread(path+filename))
    for i in range(len(b)):
        int_array.append(b)
    if i % 2 == 1:
        x.append(int_array)
        if j % 2 == 0:
            y.append(0)
        else:
            y.append(1)
        j += 1

train_x, train_y, test_x, test_y = train_test_split(x, y, test_size=0.2, random_state=42)

model = keras.Sequential([
   keras.layers.Dense(len(x), activation=tf.nn.relu, input_shape=(len(x), len(x[0]))),
   keras.layers.Dense(128, activation=tf.nn.relu),
   keras.layers.Dense(2, activation=tf.nn.softmax)
])
lo = "sparse_categorical_crossentropy"
m = ["accuracy"]
model.compile(optimizer=tf.train.AdamOptimizer(), loss=lo, metrics=m)
model.fit(train_x, train_y, epochs=3, steps_per_epoch=50)
test_loss, test_acc = model.evaluate(test_x, test_y, steps=10)
print(f"Accuracy = {test_acc}")

predictions = model.predict(test_x)
print(np.argmax(predictions[0]))
'''
