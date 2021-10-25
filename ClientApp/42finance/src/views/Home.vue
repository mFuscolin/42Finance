<template>
  <v-container>
    <v-row>
      <v-col>
        <v-card class="mx-auto" width="400" height="200">
          <v-list-item three-line>
            <v-list-item-content>
              <v-list-item-title class="text-h5 mb-1">
                Raul Seixas
              </v-list-item-title>

              <v-list-item-subtitle class="green--text text-h6"
                >R$ 30,00</v-list-item-subtitle
              >
            </v-list-item-content>

            <v-list-item-avatar tile size="80" color="grey">
              <img src="@/assets/raul.jpg" alt="avatar"
            /></v-list-item-avatar>
          </v-list-item>

          <v-card-actions>
            <v-speed-dial
              v-model="fab"
              direction="right"
              transition="slide-x-transition"
            >
              <template v-slot:activator>
                <v-btn v-model="fab" color="blue darken-2" dark fab>
                  <v-icon v-if="fab"> mdi-close </v-icon>
                  <v-icon v-else> mdi-account-circle </v-icon>
                </v-btn>
              </template>
              <v-btn fab dark small color="green">
                <v-icon>mdi-pencil</v-icon>
              </v-btn>
              <v-btn fab dark small color="indigo">
                <v-icon>mdi-plus</v-icon>
              </v-btn>
              <v-btn fab dark small color="red">
                <v-icon>mdi-delete</v-icon>
              </v-btn>
            </v-speed-dial>
          </v-card-actions>
        </v-card>
      </v-col>

      <v-col>
        <v-card class="mx-auto" width="400" height="200">
          <v-list-item three-line>
            <v-list-item-content>
              <v-list-item-title class="text-h5 mb-1">
                Rita Lee
              </v-list-item-title>
              <v-list-item-subtitle class="red--text text-h6"
                >R$ 30,00</v-list-item-subtitle
              >
            </v-list-item-content>

            <v-list-item-avatar tile size="80" color="grey">
              <img src="@/assets/rita.jpg" alt="avatar"
            /></v-list-item-avatar>
          </v-list-item>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>