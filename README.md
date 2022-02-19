# EF_CodeFirst

***Для реализации заданий используйте подход Code first
(создание базы данных на основе классов). Желательная
структура solution (решения): dll проект для хранения
классов со структурой данных(модели), dll проект для хранения класса-наследника от DbContext, приложение для
тестирования функциональности (консольное или оконное).***

# Задание 1

Создайте dll проект. Внутри проекта создайте класс
(модель) для хранения информации об играх. В классе
необходимо хранить:

■ Название игры;

■ Студия или фирма создатель игры;

■ Стиль игры;

■ Дата релиза.

# Задание 2

Создайте dll проект. Внутри проекта реализуйте следующую функциональность:

■ Создайте класс-наследник от DbContext;

■ Создайте DbSet в котором вы будете хранить объекты
класса из первого задания;

■ Настройте подключение к базе данных.

# Задание 3:

Создайте исполняемое приложение для тестирования
функциональности первого и второго задания. Необходимо:

■ Создать базу данных из класса-модели;

■ Выполнить подключение к созданной базе данных;

■ Внести информацию о нескольких играх внутрь базы
данных;

■ Отобразить информацию об играх из базы данных.
