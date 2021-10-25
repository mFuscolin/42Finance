<template>
  <v-menu bottom min-width="220px" rounded offset-y>
    <template v-slot:activator="{ on }">
      <v-btn icon large v-on="on" class="mx-1">
        <v-avatar color="blue" class="profile">
          <span v-if="!user.avatar" class="white--text text-h6">{{
            user.iniciais
          }}</span>
          <img
            aspect-ratio="1"
            v-else
            alt="Avatar"
            src="@/assets/avatar.jpeg"
          />
        </v-avatar>
      </v-btn>
    </template>
    <v-card max-width="220px">
      <v-list-item-content>
        <div class="mx-auto text-center">
          <v-avatar color="blue" class="mb-2">
            <span v-if="!user.avatar" class="white--text text-h5">{{
              user.iniciais
            }}</span>
            <img
              aspect-ratio="1"
              v-else
              alt="Avatar"
              src="@/assets/avatar.jpeg"
            />
          </v-avatar>
          <h3 class="font-weight-medium">{{ user.nome }}</h3>
          <p class="text-caption mt-1">
            {{ user.email }}
          </p>
        </div>

        <div class="px-3">
          <v-divider class="my-3"></v-divider>

          <v-icon size="25px">mdi-account-plus</v-icon>
          <v-btn rounded text small class="text-capitalize"
            >Adicionar Usuário</v-btn
          >

          <v-divider class="my-3"></v-divider>

          <v-icon size="25px">mdi-cog</v-icon>
          <v-btn rounded text small class="text-capitalize">
            Preferências
          </v-btn>

          <v-divider class="my-3"></v-divider>

          <v-icon size="25px" color="red">mdi-logout-variant</v-icon>
          <v-btn
            rounded
            text
            small
            color="red"
            size="32px"
            @click="$router.push('/')"
            >Sair</v-btn
          >
        </div>
      </v-list-item-content>
    </v-card>
  </v-menu>
</template>

<script>
export default {
  data: () => ({
    user: {
      avatar: true,
      iniciais: "EL",
      nome: "Erick Lacerda",
      email: "eck.lacerda@gmail.com",
    },
  }),
};
</script>