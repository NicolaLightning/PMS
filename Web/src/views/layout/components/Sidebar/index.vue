<template>
    <div  :class="logo">
        <logo />
        <el-scrollbar wrap-class="scrollbar-wrapper">
            <el-menu 
              :default-active="activeMenu"
              :unique-opened="false"
              mode="vertocal"
            >
            </el-menu>
        </el-scrollbar>
    </div>
</template>

<script>
import { mapGetters } from 'vuex'
import Logo from './Logo'
export default {
    computed: {
      ...mapGetters([
        'permission_routes',
        'siderbar'
      ]),
      activeMenu() {
        const route =this.$route
        const { meta, path} = route
        if (meta.activeMenu) {
            return meta.activeMenu
        }
        return path
      },
    },

}
</script>