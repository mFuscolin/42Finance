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
              <img src="@/assets/logo.png" alt="Logo 42 Finance" height="80" />
            </v-row>
          </v-col>

          <v-col cols="10 py-0">
            <h1 class="text-left">Bem-vindo!</h1>

            <p class="text-left">Faça login em sua conta</p>

            <v-text-field
              label="Usuário"
              outlined
              class="text-body-2 white"
              dense
            ></v-text-field>

            <v-text-field
              :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
              :type="showPassword ? 'text' : 'password'"
              @click:append="showPassword = !showPassword"
              dense
              label="Senha"
              outlined
              class="text-body-2 white"
            ></v-text-field>
          </v-col>

          <v-row>
            <v-col cols="5" class="ml-auto pb-0">
              <v-checkbox
                v-model="lembrar"
                :label="'Lembrar'"
                class="mt-0 pt-0"
                color="info"
              ></v-checkbox>
            </v-col>
            <v-col cols="5" class="mr-auto pb-0">
              <a
                target="_blank"
                href="https://pt.org.br/wp-content/uploads/2020/07/whatsapp-image-2020-07-07-at-20-54-17-780x440.jpeg"
                @click.stop
              >
                Esqueci a senha
              </a>
            </v-col>
          </v-row>

          <v-col cols="10">
            <v-btn
              color="blue"
              class="white--text font-weight-bold text-capitalize"
              block
              @click="$router.push('/home')"
              >Entrar</v-btn
            >
          </v-col>

          <v-col cols="10" class="py-0">
            <p class="text-left ma-0">
              Ainda não é usuário?
              <a
                target="_blank"
                href="https://pbs.twimg.com/media/ExWYdAhXEAEHYG9?format=jpg&name=medium"
                @click.stop
                class="pl-7"
              >
                Cadastre-se aqui
              </a>
            </p>
          </v-col>

          <v-col cols="10" class="d-flex flex-row align-center">
            <v-divider class="py-0" width="30%"></v-divider>
            <p class="my-0" style="width: 10%">ou</p>
            <v-divider class="py-0" width="30%"></v-divider>
          </v-col>

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
      show1: false,
      showPassword: "Password",
      lembrar: true,
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