using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonDelegate
{
    class MessageSender
    {
        public void SmsSender(Task task,string sms)
        {
            task(sms);
        }
    }
}
