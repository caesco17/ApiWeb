using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class SendingMessagesController : ApiController
    {
        private cbs_testEntities db = new cbs_testEntities();
        [HttpPost]
        public IHttpActionResult Post(int MessageId, string Sent_Date, string Confirmation_Code)
        {
            tbl_SendingMessages msg = new tbl_SendingMessages();

            msg.Sent_Date = Convert.ToDateTime(Sent_Date);
            msg.MessageId = MessageId;
            msg.Confirmation_Code = Confirmation_Code;

            try
            {
                db.tbl_SendingMessages.Add(msg);
                db.SaveChanges();

            }catch(Exception ex)
            {
                throw ex;
            }

            return CreatedAtRoute("DefaultApi", new { id = msg.MessageId }, msg);
        }
    }
}
