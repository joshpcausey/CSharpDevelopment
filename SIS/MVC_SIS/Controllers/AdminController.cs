using Exercises.Models.Data;
using Exercises.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Controllers
{
	public class AdminController : Controller
	{
		[HttpPost]
		public ActionResult DeleteCoursePost(string CourseId)
		{
			CourseRepository.Delete(int.Parse(CourseId));
			return RedirectToAction("Courses", "Admin");
		}

		[HttpGet]
		public ActionResult DeleteCourse(string id)
		{
			Course model = new Course();
			model = CourseRepository.Get(int.Parse(id));
			return View(model);
		}

		[HttpPost]
		public ActionResult EditCourse(string CourseId, string CourseName)
		{
			Course courseToEdit = new Course();
			courseToEdit.CourseId = int.Parse(CourseId);
			courseToEdit.CourseName = CourseName;
			CourseRepository.Edit(courseToEdit);
			return RedirectToAction("Courses", "Admin");
		}

		[HttpGet]
		public ActionResult EditCourse(string id)
		{
			int idInt = int.Parse(id);
			Course model = new Course();
			model = CourseRepository.Get(idInt);
			return View(model);
		}

		[HttpPost]
		public ActionResult AddCourse(string CourseName)
		{
			CourseRepository.Add(CourseName);
			return RedirectToAction("Courses", "Admin");
		}

		[HttpGet]
		public ActionResult AddCourse()
		{
			Course model = new Course();
			return View(model);
		}

		[HttpGet]
		public ActionResult Courses()
		{
			List<Course> model = new List<Course>();
			model = CourseRepository.GetAll().ToList();
			return View(model);
		}

		[HttpPost]
		public ActionResult DeleteStatePost(string StateAbbreviation)
		{
			StateRepository.Delete(StateAbbreviation);
			return RedirectToAction("States", "Admin");
		}

		[HttpGet]
		public ActionResult DeleteState(string id)
		{
			State model = new State();
			model = StateRepository.Get(id);
			return View(model);
		}

		[HttpPost]
		public ActionResult EditState(string StateAbbreviation, string StateName)
		{
			State stateToEdit = new State();
			stateToEdit.StateAbbreviation = StateAbbreviation;
			stateToEdit.StateName = StateName;
			StateRepository.Edit(stateToEdit);
			return RedirectToAction("States", "Admin");
		}
		[HttpGet]
		public ActionResult EditState(string id)
		{
			State model = new State();
			model = StateRepository.Get(id);
			return View(model);
		}
		[HttpGet]
		public ActionResult AddState()
		{
			State model = new State();
			return View(model);
		}

		[HttpPost]
		public ActionResult AddState(State state)
		{
			StateRepository.Add(state);
			List<State> model = new List<State>();
			model = StateRepository.GetAll().ToList();
			return View("States", model);
		}

		[HttpGet]
		public ActionResult States()
		{
			List<State> model = new List<State>();
			model = StateRepository.GetAll().ToList();
			return View(model);
		}

		[HttpGet]
		public ActionResult Majors()
		{
			var model = MajorRepository.GetAll();
			return View(model.ToList());
		}

		[HttpGet]
		public ActionResult AddMajor()
		{
			return View(new Major());
		}

		[HttpPost]
		public ActionResult AddMajor(Major major)
		{
			MajorRepository.Add(major.MajorName);
			return RedirectToAction("Majors");
		}

		[HttpGet]
		public ActionResult EditMajor(int id)
		{
			var major = MajorRepository.Get(id);
			return View(major);
		}

		[HttpPost]
		public ActionResult EditMajor(Major major)
		{
			MajorRepository.Edit(major);
			return RedirectToAction("Majors");
		}

		[HttpGet]
		public ActionResult DeleteMajor(int id)
		{
			var major = MajorRepository.Get(id);
			return View(major);
		}

		[HttpPost]
		public ActionResult DeleteMajor(Major major)
		{
			MajorRepository.Delete(major.MajorId);
			return RedirectToAction("Majors");
		}

	}
}