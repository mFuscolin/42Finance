import Vue from 'vue';
import VueRouter from 'vue-router';
import home from '../views/Home.vue';
import cadastro from '../views/login/cadastro.vue';
import login from '../views/login/login.vue';
import pessoa from "../views/pessoa/pessoa.vue";

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'login',
    component: login,
    meta: { anonimo: true }
  },
  {
    path: '/cadastro',
    name: 'cadastro',
    component: cadastro,
    meta: { anonimo: true }
  },
  {
    path: '/home',
    name: 'home',
    component: home,
  },
  //Pessoas
  {
    path: '/pessoa',
    name: 'pessoa',
    component: pessoa
  },
]

const router = new VueRouter({
  mode: 'history',
  routes
})

export default router
