using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Studio : ICloneable
{
    private string name;
    private string address;
    private int numberEmployees;
    private double trackPrice;
    private double trackCreationTime;
    private double totalSalary;
    private double singleSalary;
    private int numberTools;
    private int numberRooms;

    public Studio(
        string name,
        string address,
        int numberEmployees,
        double trackPrice,
        double trackCreationTime,
        double salary,
        int numberTools,
        int numberRooms
    )
    {
        this.name = name;
        this.address = address;
        this.numberEmployees = numberEmployees;
        this.trackPrice = trackPrice;
        this.trackCreationTime = trackCreationTime;
        this.singleSalary = salary;
        this.totalSalary = salary * numberEmployees;
        this.numberTools = numberTools;
        this.numberRooms = numberRooms;
    }

    private Studio(
        string name,
        string address,
        int numberEmployees,
        double trackPrice,
        double trackCreationTime,
        double totalSalary,
        double singleSalary,
        int numberTools,
        int numberRooms
    )
    {
        this.name = name;
        this.address = address;
        this.numberEmployees = numberEmployees;
        this.trackPrice = trackPrice;
        this.trackCreationTime = trackCreationTime;
        this.totalSalary = totalSalary;
        this.singleSalary = singleSalary;
        this.numberTools = numberTools;
        this.numberRooms = numberRooms;
    }

    public double this[int index]
    {
        get { return index == 0 ? singleSalary : totalSalary; }
        set
        {
            if (index == 0)
            {
                singleSalary = value;
            }
            else
            {
                totalSalary = value;
            }
        }
    }

    public override string ToString()
    {
        return $"Назва {name}\n"
            + $"Адреса {address}\n"
            + $"К-сть співробітників {numberEmployees}\n"
            + $"Вартість одного треку {trackPrice}\n"
            + $"Час створення одного треку {trackCreationTime}\n"
            + $"ЗП одного співробітника {this[0]}\n"
            + $"Загальна ЗП всіх співробітників {this[1]}\n"
            + $"К-сть інструментів {numberTools}\n"
            + $"К-сть кімнат {numberRooms}\n";
    }

    public object Clone()
    {
        return new Studio(
            name + "copy",
            address,
            numberEmployees,
            trackPrice,
            trackCreationTime,
            totalSalary,
            singleSalary,
            numberTools,
            numberRooms
        );
    }

    public static Studio operator --(Studio s)
    {
        s.numberRooms--;
        return s;
    }

    public static Studio operator ++(Studio s)
    {
        s.numberRooms++;
        s.numberTools += 2;
        s.numberEmployees += 2;
        s[1] += s[0] * 2;
        return s;
    }

    public string addRoom()
    {
        if (this.numberTools / this.numberRooms > 2 && this.numberEmployees / this.numberRooms > 2)
        {
            this.numberRooms++;
            return $"До студії {name} додано одну кімнату";
        }
        return $"Нажаль, на студії {name} недостатньо співробітників для ще однієї кімнати";
    }

    public string removeRoom()
    {
        this.numberRooms--;
        return $"У студії {name} видалено одну кімнату";
    }

    public string addEmployee()
    {
        this.numberEmployees++;
        this[1] += this[0];
        return $"На студію {name} додано одого співробіттника";
    }

    public string removeEmployee()
    {
        this.numberEmployees--;
        this[1] -= this[0];
        return $"Із студії {name} звільнено одного співробітника";
    }

    public string getName()
    {
        return name;
    }
}
