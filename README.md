## Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GutHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
**Примеры:**
["hello", "2", "world", ":-)"] -> ["2", ":-)']
["1234", "1567", "-2", "That's Jason Bourne"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

## Краткое описание алгоритма решения задачи (основной функции):
На вход функции подаются 2 аргумента: исходный массив и длина строки, по которой нужно отфильтровать элементы массива.
Создаем пустую строку, в которую будем складывать элементы исходного массива, удовлетворяющие условию.
С помощью цикла for, ограниченного длиной массива пробегаемся по элементам массива (строкам) и с помощью оператора ветвления if сравниваем длину каждого элемента с заранее заданным числом (например 3).
В случае выполнения условия, при котором длина строки (элемента массива) меньше или равна 3, добавляем этот элемент в заранее созданную пустую строку и далее добавляем символ пробела.
После окончания цикла получившуюся строку оператором split разбиваем на новый массив, используя как разделитель элементов символ пробела.
Возвращаем получившийся массив.