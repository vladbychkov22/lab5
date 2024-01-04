using System;

public class Task
{
    // Поля класу Task
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    
    // Конструктор класу Task
    public Task(string description, DateTime deadline)
    {
        Description = description;
        Deadline = deadline;
    }
    
    // Метод для виведення інформації про завдання
    public void DisplayTaskInfo()
    {
        Console.WriteLine($"Завдання: {Description}");
        Console.WriteLine($"Крайній термін: {Deadline}");
    }
}

public class Calendar
{
    // Поля класу Calendar
    public string Title { get; set; }
    public DateTime Date { get; set; }
    
    // Конструктор класу Calendar
    public Calendar(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }
    
    // Метод для виведення інформації про подію в календарі
    public void DisplayEventInfo()
    {
        Console.WriteLine($"Подія: {Title}");
        Console.WriteLine($"Дата: {Date}");
    }
}

public class Reminder
{
    // Поля класу Reminder
    public string Message { get; set; }
    public DateTime AlertTime { get; set; }
    
    // Конструктор класу Reminder
    public Reminder(string message, DateTime alertTime)
    {
        Message = message;
        AlertTime = alertTime;
    }
    
    // Метод для виведення нагадування
    public void DisplayReminder()
    {
        Console.WriteLine($"Нагадування: {Message}");
        Console.WriteLine($"Час: {AlertTime}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Демонстрація використання створених класів
        
        // Приклад створення об'єктів класу Task
        Task task = new Task("Підготувати звіт", new DateTime(2023, 12, 30));
        task.DisplayTaskInfo();
        
        // Приклад створення об'єктів класу Calendar
        Calendar event1 = new Calendar("Конференція", new DateTime(2023, 12, 25));
        event1.DisplayEventInfo();
        
        // Приклад створення об'єктів класу Reminder
        Reminder reminder = new Reminder("Подати заявку", new DateTime(2023, 12, 28));
        reminder.DisplayReminder();
    }
}