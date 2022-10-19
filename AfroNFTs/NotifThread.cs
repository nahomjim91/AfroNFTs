using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfroNFTs.Utils;
namespace AfroNFTs
{
    public class NotifThread : Task
    {
        
        public NotifThread(Action action) : base(action)
        {
            var task = Task.Run(async () => {
                for (; ; )
                {
                    await Task.Delay(10000);
                    AppEventUtils.showOutSideNotif("Hi", "THis is aw");
                          
                }
            });
        }
    }
}
