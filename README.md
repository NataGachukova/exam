## Итоговая проверочная работа

Реализована на C-Sharp программа, выполняющая задачу: 

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

Исходный код программы в файле task111.cs.
Создан метод DoTask, который принимает на вход заданный массив и возвращет массив с элементами, размером меньше или равным трем символам.

## Описание алгоритма ##

+ Задаем массив строк.
+ Первым циклом считаем количество коротких строк в исходном массиве.
+ Создаем второй массив, размером, найденным в первом цикле.
+ Вторым циклом мы заполняем второй массив короткими строками, выбранными из первого массива.
+ Выводим второй массив.