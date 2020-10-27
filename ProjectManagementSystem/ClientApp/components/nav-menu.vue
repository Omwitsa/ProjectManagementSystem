<template>
<div class="sidebar" id="sidebar">
                <div class="sidebar-inner slimscroll">
                	<form action="search.html" class="mobile-view">
						<input class="form-control" type="text" placeholder="Search here">
						<button class="btn" type="button"><i class="fa fa-search"></i></button>
					</form>
					<div id="sidebar-menu" class="sidebar-menu">

						<ul>
							<li class="nav-item nav-profile">
				              <a href="#" class="nav-link">
				                <div class="nav-profile-image">
				                  <img src="assets/img/profiles/avatar-17.jpg" alt="profile">
				                  
				                </div>
				                <div class="nav-profile-text d-flex flex-column">
				                  <span class="font-weight-bold mb-2">David Grey. H</span>
				                  <span class="text-white text-small">Project Manager</span>
				                </div>
				                <i class="mdi mdi-bookmark-check text-success nav-profile-badge"></i>
				              </a>
				            </li>
							<li class="menu-title"> 
								<span>Main</span>
							</li>
							<li class="submenu">
								<a href="#"><i class="fa fa-tachometer" aria-hidden="true"></i> <span> Dashboard</span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li><a href="index.html" class="active">Deals Dashboard</a></li>
									<li><a href="projects-dashboard.html">Projects Dashboard</a></li>
									<li><a href="leads-dashboard.html">Leads Dashboard</a></li>
								</ul>
							</li>
							
							<li> 
								<a href="tasks.html"><i class="fa fa-check-square-o" aria-hidden="true"></i> <span>Tasks</span></a>
							</li>
							<li> 
								<a href="contacts.html"><i class="fa fa-address-book-o" aria-hidden="true"></i> <span>Contacts</span></a>
							</li>
							<li> 
								<a href="companies.html"><i class="fa fa-building-o" aria-hidden="true"></i> <span>Companies</span></a>
							</li>
							<li> 
								<a href="leads.html"><i class="fa fa-user-o" aria-hidden="true"></i> <span>Leads</span></a>
							</li>
							
							<li> 
								<a href="deals.html"><i class="fa fa-podcast" aria-hidden="true"></i> <span>Deals</span></a>
							</li>
							<li> 
								<a href="projects.html"><i class="fa fa-cubes" aria-hidden="true"></i> <span>Projects</span></a>
							</li>
							<li> 
								<a href="reports.html"><i class="fa fa-bar-chart" aria-hidden="true"></i> <span>Reports</span></a>
							</li>
							<li> 
								<a href="activities.html"><i class="fa fa-calendar-check-o" aria-hidden="true"></i> <span>Activities</span></a>
							</li>
							<li> 
								<a href="email.html"><i class="fa fa-envelope-o" aria-hidden="true"></i> <span>Email</span></a>
							</li>
							
							<li class="menu-title"> 
								<span>Pages</span>
							</li>
							
							<li class="submenu">
								<a href="#"><i class="fa fa-exclamation-triangle" aria-hidden="true"></i> <span> Error Pages </span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li><a href="error-404.html">404 Error </a></li>
									<li><a href="error-500.html">500 Error </a></li>
								</ul>
							</li>
							
							<li class="submenu">
								<a href="#"><i class="fa fa-columns" aria-hidden="true"></i> <span> Pages </span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li><a href="faq.html"> FAQ </a></li>
									<li><a href="terms.html"> Terms </a></li>
									<li><a href="privacy-policy.html"> Privacy Policy </a></li>
									<li><a href="blank-page.html"> Blank Page </a></li>
								</ul>
							</li>
							<li class="menu-title"> 
								<span>UI Interface</span>
							</li>
							<li> 
								<a href="components.html"><i class="fa fa-puzzle-piece" aria-hidden="true"></i> <span>Components</span></a>
							</li>
							<li class="submenu">
								<a href="#"><i class="fa fa-object-ungroup" aria-hidden="true"></i> <span> Forms </span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li><a href="form-basic-inputs.html">Basic Inputs </a></li>
									<li><a href="form-input-groups.html" >Input Groups </a></li>
									<li><a href="form-horizontal.html">Horizontal Form </a></li>
									<li><a href="form-vertical.html"> Vertical Form </a></li>
									<li><a href="form-mask.html"> Form Mask </a></li>
									<li><a href="form-validation.html"> Form Validation </a></li>
								</ul>
							</li>
							<li class="submenu">
								<a href="#"><i class="fa fa-table" aria-hidden="true"></i> <span> Tables </span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li><a href="tables-basic.html">Basic Tables </a></li>
									<li><a href="data-tables.html">Data Table </a></li>
								</ul>
							</li>
							<li class="menu-title"> 
								<span>Extras</span>
							</li>
							
							<li class="submenu">
								<a href="javascript:void(0);"><i class="fa fa-retweet" aria-hidden="true"></i> <span>Multi Level</span> <span class="menu-arrow"></span></a>
								<ul class="sub-menus">
									<li class="submenu">
										<a href="javascript:void(0);"> <span>Level 1</span> <span class="menu-arrow"></span></a>
										<ul class="sub-menus">
											<li><a href="javascript:void(0);"><span>Level 2</span></a></li>
											<li class="submenu">
												<a href="javascript:void(0);"> <span> Level 2</span> <span class="menu-arrow"></span></a>
												<ul class="sub-menus">
													<li><a href="javascript:void(0);">Level 3</a></li>
													<li><a href="javascript:void(0);">Level 3</a></li>
												</ul>
											</li>
											<li><a href="javascript:void(0);"> <span>Level 2</span></a></li>
										</ul>
									</li>
									<li>
										<a href="javascript:void(0);"> <span>Level 1</span></a>
									</li>
								</ul>
							</li>
						</ul>
					</div>
                </div>
            </div>
    <!-- <div class="main-nav">
        <nav class="navbar navbar-expand-md navbar-dark bg-dark">
            <button class="navbar-toggler" type="button" @click="toggleCollapsed">
                <span class="navbar-toggler-icon"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <router-link class="navbar-brand" to="/"><icon :icon="['fab', 'microsoft']"/> ASP.NET Core with Vue.js 2</router-link>

            <transition name="slide">
                <div :class="'collapse navbar-collapse' + (!collapsed ? ' show':'')" v-show="!collapsed">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item" v-for="(route, index) in routes" :key="index">
                            <router-link :to="route.path" exact-active-class="active">
                                <icon :icon="route.icon" class="mr-2" /><span>{{ route.display }}</span> 
                            </router-link>
                        </li>
                    </ul>
                </div>
            </transition>
        </nav>
    </div> -->
</template>

<script>
    import { routes } from '../router/routes'

    export default {
      data () {
        return {
          routes,
          collapsed: true
        }
      },
      methods: {
        toggleCollapsed: function (event) {
          this.collapsed = !this.collapsed
        }
      }
    }
</script>

<style scoped>
    .slide-enter-active, .slide-leave-active {
    transition: max-height .35s
    }
    .slide-enter, .slide-leave-to {
    max-height: 0px;
    }

    .slide-enter-to, .slide-leave {
    max-height: 20em;
    }
</style>