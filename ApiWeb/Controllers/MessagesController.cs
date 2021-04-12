using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class MessagesController : ApiController
    {
        private cbs_testEntities db = new cbs_testEntities();

        public MessagesController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        public IQueryable<tbl_Messages> Get()
        {
            return db.tbl_Messages;
        }

        [HttpPost]
        public IHttpActionResult Post(string Created_Date, string SendTo, string MessageValue)
        {
            tbl_Messages msg = new tbl_Messages();

            msg.Created_Date = Convert.ToDateTime(Created_Date);
            msg.SendTo = SendTo;
            msg.MessageValue = MessageValue;

            db.tbl_Messages.Add(msg);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = msg.MessageId }, msg);
        }
    }
}
