import request from '@/utils/request'

export function login (username, password) {
  return request({
    url: '/admin/login',
    method: 'post',
    data: {
      username,
      password
    }
  })
}

// export function login (username, password) {
//   return new Promise((resolve, reject) =>
//     resolve(8888888)
//   )
// }

export function getInfo () {
  return request({
    url: '/LoginManage/getinfo',
    method: 'get'
  })
}

export function logout () {
  return request({
    url: '/LoginManage/logout',
    method: 'post'
  })
}
