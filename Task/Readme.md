# Итоговая проверочная работа.
## Условие задачи:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание метода предоставленного в виде блок-схемы:

* Дан исходный массив строк. Колличество элементов  - count. Индекс элемента - i.
* Формируемый массив. Индекс его элементов - index.
* Используя цикл, опрашивается каждый элемент исходного массива.
* Когда условие для элемента, длинна строки меньше или равна 3 символа, выполняется, элемент добавляется в новый массив.

## Блок схема представлена файлами blokshema.drawio и blokshema.drawio.png

## Решение задачи на языке C# в файле Program.cs:

1. Допустим пользователь вводит в консоль произвольный массив.

2. Подсчитываем сколько строк удовлетворяет условиям задачи и присваиваем значение
переменной index.

3. Формируем новый массив с количеством элементов index.

4. Выводим в консоль.

### GetInputArrayFromString - метод заполнения массива.

### MainTask - метод формирования нового массива.

### PrintArray - метод вывода массива в консоль.
