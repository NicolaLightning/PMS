<template>
  <el-container  class="mainContainer">
    <el-header>
      <header-bar> </header-bar>
    </el-header>
    <el-container>
      <el-aside width="200px" style="background-color: rgb(238, 241, 246)">
        <el-menu
          :default-openeds="$router.path"
          class="el-menu"
          router
          @open="handleOpen"
        >
          <el-menu-item index="/dashboard">
            <template slot="title">
              <span slot="title">首页</span>
            </template>
          </el-menu-item>
          <el-menu-item index="/orderManage">
            <template slot="title">
              <span slot="title">订单管理</span>
            </template>
          </el-menu-item>
        </el-menu>
      </el-aside>
      <el-main>
        <router-view />
      </el-main>
    </el-container>
  </el-container>
</template>

<script>
import HeaderBar from './components/headerbar'

const Item = {
  date: '2016-05-02',
  name: '王小虎',
  address: '上海市普陀区金沙江路 1518 弄'
}

export default {
  name: 'Layout',
  components: {
    HeaderBar
  },

  data () {
    return {
      item: Item,
      tableData: []
    }
  },

  computed: {},

  methods: {
    handleOpen () {}
  }
}
</script>

<style>
.mainContainer {
  height: 100%;
}
.el-header {
  background-color: #b3c0d1;
  color: #333;
  line-height: 60px;
}

.el-menu {
  height: 100%;
}

.el-aside {
  color: #333;
}
</style>
