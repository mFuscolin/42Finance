import '@fortawesome/fontawesome-free/css/all.css'
import '@mdi/font/css/materialdesignicons.css'
import 'font-awesome/css/font-awesome.min.css'
import 'material-design-icons-iconfont/dist/material-design-icons.css'
import Vue from 'vue'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'
import en from 'vuetify/es5/locale/en'
import pt from 'vuetify/es5/locale/pt'


Vue.use(Vuetify)

export default new Vuetify({
  lang: {
    locales: { pt, en },
    current: 'pt'
  },
  icons: {
    iconfont: 'mdi' || 'md' || 'fa4' || 'fa'
  },
  theme: {
    themes: {
      light: {
        cinzaPrimario: '#fff',
        cinzaSecundario: '#23282c',
        cinzaTerciario: '#50555A'
      },
    },
  },
})