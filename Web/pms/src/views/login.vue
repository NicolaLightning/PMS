<template>
  <div>
    <h1>登录页面</h1>
    <el-input v-model="name" placeholder="请输入用户名" style="width: 300px"></el-input>
    <el-input v-model="psw" placeholder="请输入密码" style="width: 300px" show-password></el-input>
    <el-button type='primary'>默认按钮</el-button>
  </div>
</template>

<script>
export default {
  date () {
    return {
      name: '',
      psw: ''
    }
  }
}
</script>

<style scoped>

</style>
