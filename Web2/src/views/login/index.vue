<template>
  <div class="login-container">
    <div class="content">
      <div class="header">
        <a>
          <img class="logo"/>
          <span class="title">{{('PMS')}}</span>
        </a>
      </div>
      <div class="main">
        <el-form :inline="true" :model="loginform" class="demo-form-inline">
          <el-form-item label="登录页面">
            <h1>后台管理登录页面</h1>
          </el-form-item>
          <el-form-item  prop="name" label="用户名">
            <el-input v-model="loginform.name" placeholder="请输入用户名" style="width: 300px"></el-input>
          </el-form-item>
          <el-form-item prop="psw" class="密码">
            <el-input v-model="loginform.psw" placeholder="请输入密码" style="width: 300px" show-password></el-input>
          </el-form-item>
          <el-form-item>
            <el-button type='primary' @click="onloginclick">默认按钮</el-button>
          </el-form-item>
          </el-form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data () {
    return {
      loginform: {
        name: '88888888',
        psw: '8888888'
      }
    }
  },

  methods: {
    onSubmit () {
      console.log('submit!')
    },

    onloginclick () {
      var data = {
        username: this.loginform.name
      }
      console.log(data)
      this.$router.push({ path: '/dashboard' })
    }
  }
}
</script>

<style lang="scss">

</style>
