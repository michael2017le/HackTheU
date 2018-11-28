import numpy as np
import cv2 as cv
import os
import tensorflow as tf
from tensorflow import keras
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score
from tensorflow.python.keras import utils

# Path to folder of encoded non encoded pictures
path = "/Users/qwerty/Downloads/data/"

data = []
target = []
files = []

# Takes all .png files from the path whose dimensions are square with side 40
for i, filename in enumerate(os.listdir(path)):
    if filename[-4:] == ".png" and cv.imread(path + filename).shape[0] == 40:
        files.append(filename)

files.sort()

# Appends integer array of the image pixel values to 'data' list
for i in range(len(files)):
    image_name = path + files[i]
    b = bytearray(cv.imread(image_name))
    data.append(list(b))

    # Target/label values determined from file name identified by "Sten" or not
    if "Sten" in image_name:
        target.append(1)
    else:
        target.append(0)

# Preps features and labels into NumPy arrays to easily load into model
target = utils.to_categorical(target)
x = np.array(data)
y = np.array(target)

# Splits 20% of the data into the testing set that will determine its accuracy
#   and 80% of the data to train the model
train_x, test_x, train_y, test_y = train_test_split(
    x, y, test_size=0.2, random_state=42)

# Basic three-layered sequential model
model = keras.Sequential([
    keras.layers.Dense(
        train_x.shape[1],
        activation=tf.nn.relu,
        input_shape=(train_x.shape[1], )),
    keras.layers.Dense(1000, activation=tf.nn.relu),
    keras.layers.Dense(2, activation=tf.nn.softmax)
])

# Passes proper parameters to model for classification
loss = "categorical_crossentropy"
model.compile(
    loss=loss,
    optimizer=tf.train.AdamOptimizer(learning_rate=0.1),
    metrics=["accuracy"])
model.fit(train_x, train_y, epochs=5, batch_size=64)

# Determine success of model using testing set
test_loss, test_acc = model.evaluate(test_x, test_y, steps=20)
print(f"Accuracy = {test_acc}")

predictions = model.predict(test_x)

for i in range(10):
    print(f"{predictions[i]} {test_y}")
