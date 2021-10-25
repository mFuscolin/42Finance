<template>
  <span class="mx-5">
    <v-menu
      v-model="menu"
      :close-on-content-click="false"
      offset-y
      origin="center center"
      transition="scale-transition"
    >
      <template v-slot:activator="{ on, attrs }">
        <v-btn icon :attrs="attrs" v-on="on">
          <v-badge :content="messages" color="blue accent-4" bordered overlap>
            <v-icon> mdi-bell-outline </v-icon>
          </v-badge>
        </v-btn>
      </template>

      <v-card>
        <v-list-item>
          <v-list-item-content>
            <v-list-item-title
              >Notificações
              <v-chip
                color="blue lighten-5 "
                text-color="blue darken-2"
                small
                class="ml-16 font-weight-bold"
                >{{ messages + " Nova" }}</v-chip
              ></v-list-item-title
            >
          </v-list-item-content>
        </v-list-item>

        <v-divider></v-divider>

        <v-list>
          <v-list-item
            v-for="item in items"
            :key="item.title"
            :class="item.class"
          >
            <v-list-item-avatar>
              <img src="@/assets/raul.jpg" alt="avatar" />
            </v-list-item-avatar>

            <v-list-item-content>
              <v-list-item-title>{{ item.title }}</v-list-item-title>
              <v-list-item-subtitle>{{ item.subtitle }}</v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
        </v-list>

        <v-divider></v-divider>

        <v-col cols="12">
          <v-btn
            color="blue accent-4"
            class="white--text text-capitalize"
            block
            @click="messages = 0"
            >todas lidas</v-btn
          >
        </v-col>
      </v-card>
    </v-menu>
  </span>
</template>

<script>
export default {
  data: () => ({
    menu: false,
    messages: 2,
    items: [
      {
        avatar: "@/assets/raul.jpg",
        title: "Compra Mercadinho",
        subtitle: "R$ 20,00",
        class: "red lighten-5 my-1",
      },
      {
        avatar: "@/assets/raul.jpg",
        title: "Pagamento Cash-Back",
        subtitle: "R$ 32,60",
        class: "green lighten-5 my-1",
      },
    ],
  }),
};
</script>