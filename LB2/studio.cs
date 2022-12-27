using LB2.models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

internal class Studio : ICloneable
{
    public string name;
    public string address;
    int numberEmployees
    {
        get { return workersDic.Count; }
    }
    public double trackPrice;
    public double trackCreationTime;
    int numberTools
    {
        get { return instruments.Count; }
    }
    int numberRooms
    {
        get { return rooms.Count; }
    }
    public List<Room> rooms;
    public List<Instrument> instruments;
    public Dictionary<string, Worker> workersDic;

    public Studio(
        string name,
        string address,
        double trackPrice,
        double trackCreationTime,
        List<Room> rooms,
        List<Instrument> instruments,
        Dictionary<string, Worker> workersDic
    )
    {
        this.name = name;
        this.address = address;
        this.trackPrice = trackPrice;
        this.trackCreationTime = trackCreationTime;

        this.rooms = rooms;
        this.instruments = instruments;
        this.workersDic = workersDic;
    }

    private Studio(string name, string address, double trackPrice, double trackCreationTime)
    {
        this.name = name;
        this.address = address;
        this.trackPrice = trackPrice;
        this.trackCreationTime = trackCreationTime;
    }

    public override string ToString()
    {
        string roomsStr = "";
        string workersStr = "";
        string instrumentsStr = "";
        foreach (var room in rooms)
        {
            roomsStr += room.num.ToString() + "\n";
        }
        foreach (var worker in workersDic)
        {
            workersStr += worker.Key + "\n";
        }
        foreach (var instrument in instruments)
        {
            instrumentsStr += instrument.id.ToString() + "\n";
        }
        return $"Назва {name}\n"
            + $"Адреса {address}\n"
            + $"К-сть співробітників {numberEmployees}\n"
            + $"ID співробітників {workersStr}\n"
            + $"Вартість одного треку {trackPrice}\n"
            + $"Час створення одного треку {trackCreationTime}\n"
            + $"К-сть інструментів {numberTools}\n"
            + $"ID інструментів {instrumentsStr}\n"
            + $"К-сть кімнат {numberRooms}\n"
            + $"ID кімнат {roomsStr}\n";
    }

    public object Clone()
    {
        return new Studio(name + "copy", address, trackPrice, trackCreationTime);
    }

    public string addRoom(Room room)
    {
        this.rooms.Add(room);

        return $"До студії {name} додано одну кімнату";
    }

    public string? removeRoom(int roomId)
    {
        foreach (Room item in this.rooms)
        {
            if (item.num == roomId)
            {
                this.rooms.Remove(item);
                return $"У студії {name} видалено кімнату {roomId}";
            }
        }
        return null;
    }

    public Instrument? getInstrument(string id)
    {
        foreach (Instrument instrument in instruments)
        {
            if (instrument.id == id)
            {
                return instrument;
            }
        }
        return null;
    }

    public string addEmployee(Worker worker)
    {
        workersDic.Add(worker.id, worker);
        return $"На студію {name} додано одого співробіттника";
    }

    public Worker? getWorker(string id)
    {
        return workersDic[id];
    }

    public string removeEmployee(string id)
    {
        workersDic.Remove(id);
        return $"Із студії {name} звільнено одного співробітника із податковим номером {id}";
    }

    public string addFewWorkers(IEnumerable<Worker> workers)
    {
        foreach (Worker worker in workers)
        {
            workersDic.Add(worker.id, worker);
        }
        return $"На студію {name} додано співробітників: {workers.Count()}";
    }

    public string addFewInstruments(IEnumerable<Instrument> instruments)
    {
        foreach (Instrument instrument in instruments)
        {
            this.instruments.Add(instrument);
        }
        return $"На студію {name} додано співробітників: {instruments.Count()}";
    }

    public string getName()
    {
        return name;
    }

    private OpenFileDialog openFileDialog = new OpenFileDialog();
    private SaveFileDialog saveFileDialog = new SaveFileDialog();

    public bool saveData()
    {
        Stream myStream;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string folderName = Path.Combine(projectPath, "Studio");
        string path = Path.Combine(folderName, this.name);
        path += ".json";

        string json = JsonConvert.SerializeObject(this);

        File.WriteAllText(path, json);

        return true;
    }
}
