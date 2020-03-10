import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import Students from '@/components/Students';
import Instructors from '@/components/Instructors';

import Profile from "../components/Profile.vue";
import { authGuard } from "../auth/authGuard";

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Home
    },
    {
      path: '/Home',
      component: Home
    },
    {
      path: '/Students',
      component: Students
    },
    {
      path: '/Instructors',
      component: Instructors
    },

     // NEW - add the route to the /profile component
     {
      path: "/profile",
      name: "profile",
      component: Profile
    },

    {
      path: "/profile",
      name: "profile",
      component: Profile,
      beforeEnter: authGuard
    }

  ]
})