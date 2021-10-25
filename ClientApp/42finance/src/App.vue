<template>
  <v-app id="app">
    <span v-if="anonimo">
      <router-view />
    </span>

    <span v-else>
      <core-toolbar></core-toolbar>
      <core-sidebar />
      <v-main class="grey lighten-4">
        <router-view />
      </v-main>
    </span>
  </v-app>
</template>

<script>
export default {
  computed: {
    anonimo() {
      return this.$route.meta && this.$route.meta.anonimo === true;
    },
  },
};
</script>
