using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace GoodSoft
{
    internal class TraceCheck
    {
        public void checkTrace(bool chk)
        {
            int count = 0;
            if (count == 0)
            {
                count++;
                Trace.Listeners.Add(new TextWriterTraceListener("autoraization.txt"));
            }
            DateTime dateTime = new DateTime();
            if (chk)
                Trace.WriteLine("Выполнен вход:  " + DateTime.Now);
            else
                Trace.WriteLine("Неудачная попытка входа, пойман еврей:  " + DateTime.Now);
            // после прогона тестов 
            // чтобы записать буфер на диск и не потерять хвост лога
            Trace.Flush();
        }
        int counter = 0;
        public void studentDelete()
        {
            
            if (counter == 0)
            {
                counter++;
                Trace.Listeners.Add(new TextWriterTraceListener("DeleteTable.txt"));
            }
            Trace.WriteLine("Удалены данные из таблицы <Student> в " + DateTime.Now);
            Trace.Flush();
        }
        public void parentsDelete()
        {

            if (counter == 0)
            {
                counter++;
                Trace.Listeners.Add(new TextWriterTraceListener("DeleteTable.txt"));
            }
            Trace.WriteLine("Удалены данные из таблицы <Parents> в " + DateTime.Now);
            Trace.Flush();
        }
        public void specDelete()
        {

            if (counter == 0)
            {
                counter++;
                Trace.Listeners.Add(new TextWriterTraceListener("DeleteTable.txt"));
            }
            Trace.WriteLine("Удалены данные из таблицы <Specialnost> в " + DateTime.Now);
            Trace.Flush();
        }
        public void documentDelete()
        {

            if (counter == 0)
            {
                counter++;
                Trace.Listeners.Add(new TextWriterTraceListener("DeleteTable.txt"));
            }
            Trace.WriteLine("Удалены данные из таблицы <Document> в " + DateTime.Now);
            Trace.Flush();
        }

        public void groupDelete()
        {
            
            if (counter == 0)
            {
                counter++;
                Trace.Listeners.Add(new TextWriterTraceListener("DeleteTable.txt"));
            }
            Trace.WriteLine("Удалены данные из таблицы <Group> в " + DateTime.Now);
            Trace.Flush();
        }
          
        
    }
}
