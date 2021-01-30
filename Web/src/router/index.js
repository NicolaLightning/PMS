import Vue from 'vue'
import Router from 'vue-router'
import Layout from '../views/layout/index'

Vue.use(Router)

export const constantRouterMap = [
  {path: '/login', component: () => import('@/views/login/index'), hidden: true},
  {path: '/404', component: () => import('@/views/404'), hidden: true},
  {
    path: '/',
    component: Layout,
    children: [{
      path: '/dashboard',
      name: 'dashboard',
      component: () => import('@/views/dashboard/index'),
      meta: {title: '首页', icon: 'home'}
    }]
  }
]
export const asyncRouterMap = [
  {
    path: '/orderManage',
    component: Layout,
    name: 'orderManage',
    meta: {title: '订单管理', icon: 'product'},
    children: [{
      path: 'order',
      name: 'order',
      component: () => import('@/views/orderManage/index'),
      meta: {title: '订单', icon: 'product-list'}
    }]
  }
]
export default new Router({
  // mode: 'history', //后端支持可开
  scrollBehavior: () => ({y: 0}),
  routes: constantRouterMap
})
