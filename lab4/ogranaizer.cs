using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Створення консольного проекту
        // Усередині методу Main

        // 6. Визначення колекцій для органайзера

        // Для організації органайзера ми можемо використовувати різні колекції в C#
        // Припустимо, ми будемо мати список завдань (Task), календар подій (Calendar) і список нагадувань (Reminder).

        List<Task> tasks = new List<Task>(); // Список завдань
        List<Calendar> events = new List<Calendar>(); // Список подій в календарі
        List<Reminder> reminders = new List<Reminder>(); // Список нагадувань

        // Приклад додавання елементів до колекцій

        // Додамо завдання в список завдань
        tasks.Add(new Task("Написати звіт", new DateTime(2023, 12, 30)));
        tasks.Add(new Task("Підготувати презентацію", new DateTime(2023, 12, 28)));

        // Додамо події до списку подій в календарі
        events.Add(new Calendar("Конференція", new DateTime(2023, 12, 25)));
        events.Add(new Calendar("Зустріч з клієнтом", new DateTime(2023, 12, 28)));

        // Додамо нагадування до списку нагадувань
        reminders.Add(new Reminder("Подати заявку", new DateTime(2023, 12, 28)));

        // Приклад видалення елемента з колекції

        // Видалимо перше завдання зі списку завдань
        if (tasks.Count > 0)
        {
            tasks.RemoveAt(0);
        }

        // Приклад оновлення елемента в колекції

        // Оновимо дату події
        if (events.Count > 0)
        {
            events[0].Date = new DateTime(2023, 12, 26);
        }

        // Решта вашого коду для роботи з колекціями та органайзером може продовжуватися тут

        // Для демонстрації можна вивести вміст колекцій на консоль

        Console.WriteLine("Завдання:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task.Description} до {task.Deadline}");
        }

        Console.WriteLine("\nПодії в календарі:");
        foreach (var calendarEvent in events)
        {
            Console.WriteLine($"- {calendarEvent.Title} на {calendarEvent.Date}");
        }

        Console.WriteLine("\nНагадування:");
        foreach (var reminder in reminders)
        {
            Console.WriteLine($"- {reminder.Message} о {reminder.AlertTime}");
        }
    }
}

// Класи Task, Calendar, Reminder
class Task
{
    public string Description { get; set; }
    public DateTime Deadline { get; set; }

    public Task(string description, DateTime deadline)
    {
        Description = description;
        Deadline = deadline;
    }
}

class Calendar
{
    public string Title { get; set; }
    public DateTime Date { get; set; }

    public Calendar(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }
}

class Reminder
{
    public string Message { get; set; }
    public DateTime AlertTime { get; set; }

    public Reminder(string message, DateTime alertTime)
    {
        Message = message;
        AlertTime = alertTime;
    }
}
