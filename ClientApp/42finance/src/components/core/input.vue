<template>
  <span>
    <v-text-field
      v-bind="$attrs"
      v-model="model"
      v-on="$listeners"
      hint="teste"
      outlined
      class="text-body-2"
      dense
    ></v-text-field>
  </span>
</template>

<script>
export default {
  data() {
    return {
      readonly: Boolean,
    };
  },
  props: {
    value: null,
  },
  computed: {
    model: {
      get() {
        return this.value;
      },
      set(value) {
        this.$emit("input", value);
      },
    },
  },
};
</script>