//using Gary.XA.Feature.Media.Interfaces;
//using Sitecore.XA.Foundation.Mvc.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Gary.XA.Feature.Media.Controllers
//{
//    public class RelatedContentController : Controller
//    {
//        protected readonly IRelatedContentRepository RelatedContentRepository;

//        public RelatedContentController(IRelatedContentRepository relatedContentRepository)
//        {
//            this.RelatedContentRepository = relatedContentRepository;
//        }

//        protected override object GetModel()
//        {
//            return this.RelatedContentRepository.GetModel();
//        }
//    }
//}