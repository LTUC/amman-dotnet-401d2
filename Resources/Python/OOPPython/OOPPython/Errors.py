def insertionSort(array, sorted_array):
    while len(array) > 0:
        minimum = array[0]
        for i in array:
            if i < minimum:
                minimum = i
        array.remove(minimum)
        sorted_array.append(minimum)

def main():
    array = [1,5,6,4,9,10]
    sorted = []
    insertionSort(array, sorted)
    print(sorted)

main();


