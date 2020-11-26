import Vue from 'vue'
import Router from 'vue-router'
import login from '@/views/login/login'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'login',
      component: login
    },
    {
      path: '/layout',
      name: 'home',
      component: () => import('../views/layout/index'),
      children: [
        {
          path: '/dashboard',
          name: 'dashboard',
          component: () => import('@/views/dashboard/index'),
          meta: {
            title: '首页'
          }
        },
        {
          path: '/orderManage',
          name: 'orderManage',
          component: () => import('@/views/orderManage/index'),
          meta: {
            title: '订单管理'
          }
        }
      ]
    }
  ]
})
