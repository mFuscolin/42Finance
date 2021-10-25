<template>
  <v-app-bar
    height="60px"
    app
    elevation="1"
    class="font-weight-light cinzaPrimario"
  >
    <v-app-bar-nav-icon @click="alterarDrawer"></v-app-bar-nav-icon>

    <v-spacer></v-spacer>

    <core-notificacoes></core-notificacoes>
    <core-avatar></core-avatar>
  </v-app-bar>
</template>

<script>
export default {
  data() {
    return {
      hover: false,
    };
  },

  methods: {
    alterarDrawer() {
      this.$store.commit("setDrawer");
    },
  },
};
</script>