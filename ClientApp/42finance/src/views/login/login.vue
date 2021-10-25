<template>
  <v-app
    ><v-main>
      <v-row style="height: 103vh" align="center" class="justify-center">
        <v-card elevation="0" :height="height">
          <img
            src="@/assets/img-login.jpg"
            alt="Logo 42 Finance"
            :height="height"
          />
        </v-card>

        <v-card class="mx-15" width="400px" align="center">
          <v-col cols="10">
            <v-row align="center" justify="center" class="pt-5 pb-3">
              <img src="@/assets/logo.png" alt="Logo 42 Finance" height="40" />
            </v-row>
          </v-col>

          <v-col cols="10 py-0">
            <h1>Bem-vindo!</h1>

            <p>Faça login em sua conta</p>

            <v-text-field
              label="Usuário"
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

          <v-row>
            <v-col cols="5" class="ml-11 pb-0">
              <v-checkbox
                v-model="lembrar"
                :label="'Lembrar'"
                class="mt-0 pt-0"
                color="info"
              ></v-checkbox>
            </v-col>
            <v-col cols="5" class="pb-0">
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
              class="white--text font-weight-bold"
              block
              @click="$router.push('/home')"
              >Entrar</v-btn
            >
          </v-col>

          <v-col cols="10" class="py-0">
            <p class="ma-0">
              Ainda não é usuário?
              <a target="_blank" @click="$router.push('/cadastro')">
                Cadastre-se aqui
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
        (value) => (value && value.length >= 3) || "Min 3 caracteres",
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
  computed: {
    height() {
      switch (this.$vuetify.breakpoint.name) {
        case "xs":
          return 150;
        case "sm":
          return 150;
        case "md":
          return 400;
        case "lg":
          return 400;
        case "xl":
          return 600;
      }
    },
  },
};
</script>