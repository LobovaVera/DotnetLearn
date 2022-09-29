// задчки из учебника семакин

//даны декартовы координаты трех вершин треугольника на плоскости. Составитьь алгоритм вычисления площади.
// формула площадь по координатам:
// S = ½*((x1-x3)*(y2-y3) — (y1-y3)*(x2-x3)).
//Источник: https://sprint-olympic.ru/uroki/geometrija/128075-ploshad-treygolnika-po-koordinatam-vershin-formyly-dlia-rascheta.html

double x1 = 2;
double y1 = -3;
double x2 = 1;
double y2 = 1;
double x3 = -6;
double y3 = 5;

double area = 0;

double AB = (x1 - x3)*(y2-y3);

Console.WriteLine(AB);

double BC = (x2-x3)*(y1-y3);

Console.WriteLine(BC);

double temp = AB-BC;

Console.WriteLine(temp);

area = temp/2;

Console.WriteLine(area);
