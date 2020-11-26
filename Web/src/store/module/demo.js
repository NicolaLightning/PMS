export default {

    state: {

        //属性

        demoValue:{}

    },

    getters: {

        getDemoValue: state => state.demoValue

    },

    mutations: {

        //set方法

        setDemoValue(state,demoValue){

            state.demoValue = demoValue

        }

    }

}
