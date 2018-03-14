using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MemberProfiling.Models;

namespace MemberProfiling
{
    public class MemberProfilingMasterController : Controller
    {
        private MemberProfilingEntities _db = new MemberProfilingEntities();

        // GET: MemberProfilingMaster
        public ActionResult Index()
        {
            
            ViewBag.BusinessAnalysts = new SelectList(_db.Chennai_Business_Analysts, "Name", "Name");
            return View();
        }

        [HttpPost]
        public JsonResult GetMemberProfiles(string businessAnalyst, int year, int month) {
            var memberProfiles = _db.MemberProfilingMasters.Where(a=> a.SalesforceProject.BusinessAnalyst ==businessAnalyst &&  
                a.Year == year && a.Month ==month
            ).Select(a => new
            {
                a.MemberProfileKey,
                a.SalesforceProject.ProjectName,
                a.SalesforceProject.ProjectPhase,
                a.SalesforceProject.BusinessAnalyst,
                a.Services_Current_Issues,
                a.PD_Current_Issues,
                a.IsUpdated,
                Total_Score = (a.ProfilingScore.Score + a.ProfilingScore1.Score + a.ProfilingScore2.Score + a.ProfilingScore3.Score + a.ProfilingScore4.Score).ToString()
            });

            return  Json(new { MemberProfiles = memberProfiles } , JsonRequestBehavior.AllowGet);
        }




        // GET: MemberProfilingMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberProfilingMaster memberProfilingMaster = _db.MemberProfilingMasters.Find(id);
            if (memberProfilingMaster == null)
            {
                return HttpNotFound();
            }
            ViewBag.Data_Validation___Accuracy_Issues = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Data_Validation___Accuracy_Issues);
            ViewBag.Engagement = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Engagement);
            ViewBag.Data_Load___Implementation_Timeliness = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Data_Load___Implementation_Timeliness);
            ViewBag.Open_Enhancements___Defects = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Open_Enhancements___Defects);
            ViewBag.Relationship_Strength = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Relationship_Strength);
            ViewBag.Modules = new SelectList(_db.AppModules, "AppModuleKey", "ModuleName");
            ViewBag.ProjectView = _db.ProjectViews.Where(a => a.ProjectKey == memberProfilingMaster.SalesforceProject.ProjectKey).FirstOrDefault();
            ViewBag.Scores = _db.ProfilingScores.ToList();
            return View(memberProfilingMaster);
        }

        // POST: MemberProfilingMaster/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemberProfileKey,Year,Month,Project,Brief_history_of_Member,Data_Validation___Accuracy_Issues,Data_Load___Implementation_Timeliness,Relationship_Strength,Services_Current_Issues,Services_Current_Resolution_Plan,Open_Enhancements___Defects,Engagement,PD_Current_Issues,PD_Current_Resolution_Plan,IsUpdated,Overall_Comments")] MemberProfilingMaster memberProfilingMaster,
            [Bind(Include ="moduleServces,moduleProduct,moduleAccessed,moduleNotAccessed")] ModulesBridge modules)
        {
            if (ModelState.IsValid)
            {
                MemberProfilingMaster oldRec = _db.MemberProfilingMasters.Find(memberProfilingMaster.MemberProfileKey);
                oldRec.Brief_history_of_Member = memberProfilingMaster.Brief_history_of_Member;
                oldRec.Overall_Comments = memberProfilingMaster.Overall_Comments;
                oldRec.Data_Validation___Accuracy_Issues = memberProfilingMaster.Data_Validation___Accuracy_Issues;
                oldRec.Data_Load___Implementation_Timeliness = memberProfilingMaster.Data_Load___Implementation_Timeliness;
                oldRec.Relationship_Strength = memberProfilingMaster.Relationship_Strength;
                oldRec.Services_Current_Issues = memberProfilingMaster.Services_Current_Issues;
                oldRec.Services_Current_Resolution_Plan = memberProfilingMaster.Services_Current_Resolution_Plan;
                oldRec.Open_Enhancements___Defects = memberProfilingMaster.Open_Enhancements___Defects;
                oldRec.Engagement = memberProfilingMaster.Engagement;
                oldRec.PD_Current_Issues = memberProfilingMaster.PD_Current_Issues;
                oldRec.PD_Current_Resolution_Plan = memberProfilingMaster.PD_Current_Resolution_Plan;
                memberProfilingMaster.Record_Dt = DateTime.Now;
                memberProfilingMaster.IsUpdated = true;
                _db.Entry(oldRec).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Data_Validation___Accuracy_Issues = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Data_Validation___Accuracy_Issues);
            ViewBag.Engagement = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Engagement);
            ViewBag.Data_Load___Implementation_Timeliness = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Data_Load___Implementation_Timeliness);
            ViewBag.Open_Enhancements___Defects = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Open_Enhancements___Defects);
            ViewBag.Relationship_Strength = new SelectList(_db.ProfilingScores, "ProfileScoreKey", "Score", memberProfilingMaster.Relationship_Strength);
            return View(memberProfilingMaster);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
