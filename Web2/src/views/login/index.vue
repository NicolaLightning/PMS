<template>
  <div class="login-container">
    <div class="background">
    </div>
    <div class="content">
      <div class="main">
        <h1>后台管理登录页面</h1>
        <el-form :inline="true" :model="loginform" :rules="loginRules" label-width="200px" label-position="left" width="400px;" class="loginform" :style="note">
          <el-row width="400px">
            <el-col :span="4">
              <el-form-item  prop="username" label="用户名">
                <el-input v-model="loginform.username" placeholder="请输入用户名" style="width: 200px"></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-row width="400px">
            <el-col :span="4">
              <el-form-item prop="password" label="密码">
                <el-input v-model="loginform.password" placeholder="请输入密码" style="width: 200px" show-password></el-input>
              </el-form-item>
            </el-col>
          </el-row>
          <el-row width="400px">
            <el-col :span="1">
              <el-form-item>
                <el-button type='primary' @click="onloginclick">默认按钮</el-button>
              </el-form-item>
            </el-col>
          </el-row>
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
        username: '88888888',
        password: '8888888'
      },
      loginRules: {
        username: [{required: true, trigger: 'blur'}],
        password: [{required: true, trigger: 'blur'}]
      },
      note: {
        backgroundImage: 'url(' + require('@/assets/images/login.jpg') + ')',
        backgroundRepeat: 'no-repeat',
        backgroundSize: 'auto',
        marginTop: '5px'
      },
      imgSrc: require('@/assets/images/login.jpg')
    }
  },

  methods: {
    onSubmit () {
      console.log('submit!')
    },

    onloginclick () {
      var data = {
        username: this.loginform.username,
        password: this.loginform.password
      }
      console.log(data)
      console.log(data.username)
      this.$store.dispatch('Login', data).then(() => {
        this.$router.push({ path: this.redirect || '/' })
      })
    }
  }
}
</script>

<style lang="scss" scoped>
$bg: rgb(69,85,97);
$dark_gray: #889aa4;
$light_gray:#eee;

.login_container {
  min-height: 100%;
  width: 100%;
  background-color: $bg;
  overflow: hidden;

  .el-row {
    width: 400px;
  }

  .background {
    width:100%;
    height:100%;  /**宽高100%是为了图片铺满屏幕 */
    z-index:-1;
    position: absolute;
  }

  .main {
    width: 600px;
    z-index: 1;
    position: absolute;
  }

  .loginform {
    position: relative;
    max-width: 100%;
    padding: 160px 35px 0;
    margin: 0 auto;
  }

  .main {
    align-self: center;
  }
}
</style>
