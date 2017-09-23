from keras.preprocessing.image import ImageDataGenerator, array_to_img, img_to_array, load_img

datagen = ImageDataGenerator(rotation_range=40,
        width_shift_range=0.2,
        height_shift_range=0.2,
        #shear_range=0.2,
        #zoom_range=0.2,
        horizontal_flip=True,
        fill_mode='constant')


img = load_img('c.jpg')  # this is a PIL image
x = img_to_array(img)  # this is a Numpy array with shape (256, 256, 3)
x = x.reshape((1,) + x.shape)  # this is a Numpy array with shape (1, 256, 256, 3)

# the .flow() command below generates batches of randomly transformed images
# and saves the results to the `preview/` directory
i = 0
for batch in datagen.flow(x, batch_size=1, save_to_dir='preview', save_prefix='c', save_format='jpg'):
    i += 1
    if i > 20:
        break  # otherwise the generator would loop indefinitely