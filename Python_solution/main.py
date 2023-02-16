# Написать программу, которая из имеющегося массива строк формирует массив из строк,
# длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с клавиатуры,
# либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
# лучше обойтись исключительно массивами.
# Примеры:
# ["hello", "2", "world", ":-)"] -> ["2", ":-)']
# ["1234", "1567", "-2", "That's Jason Bourne"] -> ["-2"]
# ["Russia", "Denmark", "Kazan"] -> []

# Тут, все же, используются списки, а не массивы с фиксированной длиной

def array_filter(array, n):
    return [str for str in array if len(str) <= n]

if __name__ == '__main__':
    string_length = 3
    array1 = ["hello", "2", "world", ":-)"]
    array2 = ["1234", "1567", "-2", "That's Jason Bourne"]
    array3 = ["Russia", "Denmark", "Kazan"]
    print(array_filter(array1, string_length))
    print(array_filter(array2, string_length))
    print(array_filter(array3, string_length))


