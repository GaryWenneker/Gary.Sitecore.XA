//using Gary.XA.Feature.Media.Interfaces;
//using Gary.XA.Feature.Media.Models;
//using Sitecore;
//using Sitecore.Data;
//using Sitecore.XA.Feature.Search.Controllers;
//using Sitecore.XA.Feature.Search.Enums;
//using Sitecore.XA.Feature.Search.Models;
//using Sitecore.XA.Foundation.Multisite;
//using Sitecore.XA.Foundation.Mvc.Repositories.Base;
//using Sitecore.XA.Foundation.Mvc.Wrappers;
//using Sitecore.XA.Foundation.RenderingVariants.Repositories;
//using Sitecore.XA.Foundation.Search.Models;
//using Sitecore.XA.Foundation.Search.Services;
//using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;

//namespace Gary.XA.Feature.Media.Repositories
//{


//    public class RelatedContentRepository : VariantsRepository, IRelatedContentRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
//    {
//        public RelatedContentRepository(IVariantsRepository variantsRepository, IScopeService scopeService, ISiteInfoResolver siteInfoResolver)
//        {
//            this.VariantsRepository = variantsRepository;
//            this.ScopeService = scopeService;
//            this.SiteInfoResolver = siteInfoResolver;
//        }

//        public string HomeUrl => this.SiteInfoResolver.GetHomeUrl(this.PageContext.Current);


//    public string Scopes
//        => this.ScopeService.GetScopes(this.PageContext.Current, this.Rendering.Parameters["Scope"]);

//        public IScopeService ScopeService { get; set; }

//        public ISiteInfoResolver SiteInfoResolver { get; set; }

//        public IVariantsRepository VariantsRepository { get; set; }

//        protected virtual DefaultLanguageFilter DefaultLanguageFilter
//        {
//            get
//            {
//                var str = this.Rendering.Parameters["DefaultLanguageFilter"];
//                if (ID.IsID(str))
//                {
//                    var enumItem = Context.Database.GetItem(str);
//                    if (enumItem != null)
//                    {
//                        return enumItem.ToEnum<DefaultLanguageFilter>();
//                    }
//                }

//                return DefaultLanguageFilter.AllLanguages;
//            }
//        }

//        protected virtual string DefaultSortOrder
//        {
//            get
//            {
//                var defSortOrderId = this.Rendering.Parameters["DefaultSortOrder"];
//                if (!string.IsNullOrWhiteSpace(defSortOrderId) && ID.IsID(defSortOrderId))
//                {
//                    var sortOrderItem = Context.Database.GetItem(defSortOrderId);
//                    if (sortOrderItem != null)
//                    {
//                        var sortOrderFacet = string.Empty;
//                        var sortOrderDirection = string.Empty;
//                        if (ID.IsID(sortOrderItem["Facet"]))
//                        {
//                            sortOrderFacet = Context.Database.GetItem(sortOrderItem["Facet"]).Name;
//                        }

//                        if (ID.IsID(sortOrderItem["Direction"]))
//                        {
//                            sortOrderDirection = Context.Database.GetItem(sortOrderItem["Direction"]).Name;
//                        }

//                        if (!string.IsNullOrWhiteSpace(sortOrderFacet) && !string.IsNullOrWhiteSpace(sortOrderDirection))
//                        {
//                            return $"{sortOrderFacet},{sortOrderDirection}";
//                        }
//                    }
//                }

//                return string.Empty;
//            }
//        }

//        protected virtual int PageSize => this.Rendering.Parameters.ParseInt("PageSize", 20);

//        protected virtual ResultSet ResultSet
//        {
//            get
//            {
//                var webApiSearchController = new SearchController();
//                return webApiSearchController.GetResults(this.VariantItem?.ID.ToString(), null, this.Scopes);
//            }
//        }

//        public override IRenderingModelBase GetModel()
//        {
//            var resultsRenderingModel = new RelatedContentRenderingModel();
//            this.FillBaseProperties(resultsRenderingModel);
//            resultsRenderingModel.ResultSet = this.ResultSet;
//            resultsRenderingModel.StyleDisplay = !this.IsEdit && this.ResultSet.Count == 0
//                                                         ? "none"
//                                                         : "block";
//            return resultsRenderingModel;
//        }
//    }
//}