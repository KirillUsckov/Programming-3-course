# Watch task

Задание: создать механические часы с возможностью создания будильника.

## Form1 
Форма Form1 является основной и единственной.
Содержит следующие методы:

```c#
 Clock_Tick(object sender, EventArgs e)
```
 Метод Clock_Tick вызывается при увеличении таймера на 1 секунду. Отвечает за отрисовку часов, а также за включение оповещения от будильника.
```c#
 paintClock(DateTime time)
```
 Метод paintClock вызыввается из метода Clock_Tick. 
```c#
 paintCircle()
```
 Метод paintCircle вызыввается из метода paintClock. Отвечает за отрисовку циферблата.
```c#
 paintArrows(DateTime time)
```
 Метод paintArrows вызывается из метода paintArrows. Отвечает за отрисовку стрелок.