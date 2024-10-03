<template>
  <div class="container">
    <div class="large-12 medium-12 small-12 cell">
      <label>File
        <input type="file" id="file" ref="file" @change="handleFileUpload()"/>
      </label>
      <button @click="submitFile()">Submit</button>
    </div>
  </div>
</template>

<script>
import api from "@/api"

export default {
  data() {
    return {
      file: ''
    }
  },
  methods: {
    handleFileUpload() {
      this.file = this.$refs.file.files[0];
    },
    submitFile() {
      let formData = new FormData();
      formData.append('file', this.file);
      try {
        api.createItemFormData("/file", formData)
      } catch (error) {
        console.error('Error sending file', error)
      }
    }
  }
}
</script>