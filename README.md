# task-001

Задача: Реализовать консольное приложение, удовлетворяющее следующим требованиям:

1.Новогодний подарок. Определить иерархию конфет и прочих сладостей. Создать несколько объектов-конфет. Собрать детский подарок с определением его веса. Провести сортировку конфет в подарке на основе одного из параметров. Найти конфету в подарке, соответствующую заданному диапазону содержания сахара.

Описание решения:

Для сладостей общий абстрактный класс - сладостm(Sweet). Свойства: название(Name), содерждание сахара(SugarAmount), полный вес(TotalWeight), вес сахара (SugarWeight). Методы: вычисление веса сахара в сладости (DetermineSugar).

Унаследованные классы: конфеты(Candies), печенья(Cakes)(доп свойства: относительная влажность помещения хранения печенья).

Для подарка общий класс - подарки(Gift). Свойства: вес(WeightGift). Методы: найдти сладость по диапазону сахара (FindBy), Сортировка и обратная сортировка (OrderBy ,OrderByDesceding), возвращение содержания подарка (GetEnumerator).
