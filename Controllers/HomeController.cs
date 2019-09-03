using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DirectedTree.Models;
using Newtonsoft.Json;

namespace DirectedTree.Controllers
{
    public class HomeController : Controller
    {
        List<children> child= new List<children>();
       
       
        private  List<children> getChildOnParentLevelOne(int _parent){

switch(_parent)
{
    case 1:
  child=new List<children>(){
      new children() {
      name="First",
    
      child=new List<children>(){
           new children(){name="A1",value=100},
            new children(){name="A2",value=200}
      }}};
    break;

       case 2:
  
    break;

       case 3:
  
    break;

       case 4:

    break;

       case 5:
 
    break;
 
}

   return child;
        }
        public IActionResult Index()
        {
            Tree tree = new Tree();
            tree.name="Taha";
            tree.Id=1;
            tree.children=getChildOnParentLevelOne(tree.Id);
            string json = JsonConvert.SerializeObject(tree);
            ViewBag.json = json;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
