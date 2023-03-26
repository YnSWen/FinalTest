# **Итоговая проверочная работа**

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:
Первоначальный массив я задала в начале выполнения программы, он состоит из 7 элементов типа string. Далее идет метод, первый цикл в нем ищет количество элеметов, удовлетворящих условию - (<=3), это нужно для того чтобы задать размер дальнейшему результатирующему массиву. Второй цикл уже переносит значения из первого массива в результатирующий, которые удовлетворяют условию - (<=3). На выходе получаем массив строк, длина которых меньше либо равна 3 символа. 