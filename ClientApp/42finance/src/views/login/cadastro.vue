<template>
  <v-app
    ><v-main class="grey lighten-5">
      <v-row style="height: 103vh" justify="center" align="center">
        <v-card
          rounded="lg"
          min-height="500px"
          class="white"
          elevation="2"
          width="400px"
          align="center"
        >
          <v-col cols="10">
            <v-row align="center" justify="center" class="pt-5 pb-3">
              <img src="@/assets/logo.png" alt="Logo 42 Finance" height="40" />
            </v-row>
          </v-col>

          <v-col cols="10 py-0">
            <h1>Bem-vindo!</h1>

            <p>Crie sua conta e aproveite!</p>

            <v-text-field
              label="Nome do Usuário"
              :rules="rules"
              outlined
              class="text-body-2 white"
              dense
            ></v-text-field>

            <v-text-field
              label="Email"
              :rules="rules"
              outlined
              class="text-body-2 white"
              dense
            ></v-text-field>

            <v-text-field
              :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
              :type="showPassword ? 'text' : 'password'"
              :rules="rules"
              @click:append="showPassword = !showPassword"
              dense
              label="Senha"
              outlined
              class="text-body-2 white"
            ></v-text-field>
          </v-col>

          <v-col cols="10" class="pt-0">
            <v-btn
              color="blue"
              class="white--text font-weight-bold"
              block
              @click="$router.push('/')"
              >Criar</v-btn
            >
          </v-col>

          <v-col cols="10" class="py-0">
            <p class="text-left ma-0">
              Já tem uma conta?
              <a target="_blank" @click="$router.push('/')" class="pl-13">
                Faça login aqui!
              </a>
            </p>
          </v-col>

          <v-col cols="10" class="d-flex flex-row align-center">
            <v-divider class="py-0" width="30%"></v-divider>
            <p class="my-0" style="width: 10%">ou</p>
            <v-divider class="py-0" width="30%"></v-divider>
          </v-col>

          <p>Entre com sua rede social!</p>

          <v-col cols="10" class="pt-0">
            <v-card-actions class="white justify-center">
              <v-btn
                v-for="(social, i) in socials"
                :key="i"
                :color="social.color"
                class="white--text"
                icon
                large
              >
                <v-icon large>{{ social.icon }}</v-icon>
              </v-btn>
            </v-card-actions>
          </v-col>
        </v-card>
      </v-row>
    </v-main></v-app
  >
</template>

<script>
export default {
  data() {
    return {
      showPassword: false,
      lembrar: false,
      rules: [
        (value) => !!value || "Campo Obrigatório!.",
        (value) => (value && value.length >= 3) || "Min 3 characters",
      ],
      socials: [
        {
          icon: "mdi-facebook",
          color: "indigo",
        },
        {
          icon: "mdi-google-plus",
          color: "red",
        },
        {
          icon: "mdi-twitter",
          color: "blue",
        },
        {
          icon: "mdi-linkedin",
          color: "cyan darken-3",
        },
      ],
    };
  },
};
</script>