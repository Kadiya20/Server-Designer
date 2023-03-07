import { createRouter, createWebHashHistory  } from 'vue-router'
// import store from '../store.js'
import CallsView from '../views/CallsView.vue'

const router = createRouter({
  history: createWebHashHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: CallsView,
    },
    {
      path: '/',
      name: 'calls',
      meta: { authorize: true },
      component: () => import('../views/CallsView.vue')
    }
  ]
});

// router.beforeEach((to, from, next) => {
//   const authenticated = store.state.user.isLoggedIn;
//   if (to.meta.authorize && !authenticated) {
//     next("/");
//     return;
//   }
//   next();
//   return;
// });

export default router;
