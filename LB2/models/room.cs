using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB2.models
{
    internal class Room
    {
        public int num;
        public List<string> instrumentsId;
        public List<string> workersId;
        public const int minInstruments = 4;
        public const int maxInstruments = 100;
        public const int minWorkers = 4;
        public const int maxWorkers = 100;
        public const double trackPrice = 450;
        public int instruments;
        public int workers;

        public Room(
            int num,
            List<string> instrumentsId,
            List<string> workersId,
            int instruments,
            int workers
        )
        {
            this.num = num;
            this.instrumentsId = instrumentsId;
            this.workersId = workersId;
            this.instruments = instruments;
            this.workers = workers;
        }

        public override string ToString()
        {
            return $"ID {num}\n"
                + $"Інструменти {getInstrumentsId()}\n"
                + $"Співробітники {getWorkersId()}\n"
                + $"Вартість одного треку {trackPrice}\n"
                + $"Мінімальна к-сть інструментів {minInstruments}\n"
                + $"Максимальна к-сть інструментів {maxInstruments}\n"
                + $"Мінімальна к-сть співробітників {minWorkers}\n"
                + $"Максимальна к-сть співробітників {maxWorkers}\n"
                + $"К-сть інструментів {instruments}\n"
                + $"К-сть працівників {workers}\n";
        }

        private string getInstrumentsId()
        {
            string IDs = "";
            foreach (var id in instrumentsId)
            {
                IDs += id + ',';
            }
            return IDs;
        }

        private string getWorkersId()
        {
            string IDs = "";
            foreach (var id in workersId)
            {
                IDs += id + ',';
            }
            return IDs;
        }
    }
}
