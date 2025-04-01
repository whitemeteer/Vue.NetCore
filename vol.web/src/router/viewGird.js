//多个页面指向同一个菜单时请加上属性：
// meta: {
//   dynamic: true,
// }
let viewgird = [
  {
    path: '/Sys_Log',
    name: 'Sys_Log',
    component: () => import('@/views/sys/system/Sys_Log.vue')
  },
  {
    path: '/Sys_User',
    name: 'Sys_User',
    component: () => import('@/views/sys/system/Sys_User.vue')
  },
  {
    path: '/permission',
    name: 'permission',
    component: () => import('@/views/sys/Permission.vue')
  },

  {
    path: '/Sys_Dictionary',
    name: 'Sys_Dictionary',
    component: () => import('@/views/sys/system/Sys_Dictionary.vue')
  },
  {
    path: '/Sys_Role',
    name: 'Sys_Role',
    component: () => import('@/views/sys/system/Sys_Role.vue')
  },
  {
    path: '/Sys_Language',
    name: 'Sys_Language',
    component: () => import('@/views/sys/lang/Sys_Language.vue')
  },
  {
    path: '/FormDesignOptions',
    name: 'FormDesignOptions',
    component: () => import('@/views/sys/form/FormDesignOptions.vue')
  },
  {
    path: '/FormCollectionObject',
    name: 'FormCollectionObject',
    component: () => import('@/views/sys/form/FormCollectionObject.vue')
  },
  {
    path: '/Sys_QuartzOptions',
    name: 'Sys_QuartzOptions',
    component: () => import('@/views/sys/quartz/Sys_QuartzOptions.vue')
  },
  {
    path: '/Sys_QuartzLog',
    name: 'Sys_QuartzLog',
    component: () => import('@/views/sys/quartz/Sys_QuartzLog.vue')
  },
  {
    path: '/Sys_Department',
    name: 'Sys_Department',
    component: () => import('@/views/sys/system/Sys_Department.vue')
  },
  {
    path: '/Sys_Region',
    name: 'Sys_Region',
    component: () => import('@/views/sys/system/Sys_Region.vue')
  }, {
    path: '/ProductionState',
    name: 'ProductionState',
    component: () => import('@/views/mes/state/ProductionState.vue')
  }
]

export default viewgird
