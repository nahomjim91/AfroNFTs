using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AfroNFTs.Utils;
namespace AfroNFTs
{
    public class NotifThread : Task
    {
        
        public NotifThread(Action action, bool pageType) : base(action)
        {
            var task = Task.Run(async () => {
                for (; ; )
                {
                    await Task.Delay(10000);
                    if (mainPage.userID == null) return;
                    
                    //       AppEventUtils.showOutSideNotif("Hi", "THis is aw");
                    if (pageType)
                    {
                       
                        using(var actionService = new Services.ActionService(mainPage.userID))
                        {
                           
                            var allActions = actionService.getAllActionsForAdmin(mainPage.userID)
                            ;
                           // MessageBox.Show("running");
                            if (allActions == null)
                            {
                             //   MessageBox.Show("NULL ACTIONS");
                                return; 
                            }
                            foreach (var act in allActions)
                            {
                               // MessageBox.Show("LOOP!");
                                string str;
                                if (act.act == "co") str = "Comment";
                                else if (act.act == "Li") str = "Liked";
                                else if (act.act == "Di") str = "Disliked";
                                else str = "uknown";


                                int userId = act.userId;
                                
                                AppEventUtils.showOutSideNotif("Notification", $"Action: {str}, user Id: ${userId}");
                                actionService.makeActionSeen(act.id);
                            }
                        }
                    }
                }
            });
        }
    }
}
