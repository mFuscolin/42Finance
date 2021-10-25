<template>
  <v-app id="inspire" class="blue accent-4">
    <v-card flat class="blue accent-4 font-weight-light">
      <v-app-bar-title class="mt-2">
        <img src="@/assets/logo.png" alt="logo Inmasys" :width="width" />
      </v-app-bar-title>

      <v-list nav dark>
        <v-list-item
          v-for="item in items"
          :key="item.title"
          :to="item.to"
          link
          router
          class="text-left"
        >
          <v-list-item-icon>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-icon>

          <v-list-item-content>
            <v-list-item-title>{{ item.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-card>
  </v-app>
</template>

<script>
export default {
  data: () => ({
    search: null,
    items: [
      {
        icon: "mdi-home",
        to: "/Home",
        title: "Home",
      },
      {
        icon: "mdi-cash-lock",
        to: "/",
        title: "Despesas Fixas",
      },
      {
        icon: "mdi-cash-multiple",
        to: "/",
        title: "Despesas Variáveis",
      },
    ],
  }),
  computed: {
    width() {
      switch (this.$vuetify.breakpoint.name) {
        case "xs":
          return 150;
        case "sm":
          return 150;
        case "md":
          return 150;
        case "lg":
          return 200;
        case "xl":
          return 230;
      }
    },
  },
};
</script>