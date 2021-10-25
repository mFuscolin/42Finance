<template>
  <!--floating = Retira borda-->
  <v-navigation-drawer
    :value="drawer"
    width="260px"
    app
    class="text-center"
    floating
  >
    <core-sidebaritens />
  </v-navigation-drawer>
</template>

<script>
export default {
  computed: {
    drawer: {
      get() {
        return this.$store.state.drawer;
      },
    },
  },
};
</script>