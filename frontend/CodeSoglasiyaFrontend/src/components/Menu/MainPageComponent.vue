<template>
  <div class="main-page">
    <button class="add-button" @click="addFile()">
      Добавить файл
    </button>
    <div class="file-list">
      {{ file.name }}
      <img class="remove-file" src="@/assets/svg/trash-can.svg" width="16px" height="16px" v-if="file != ''" @click="removeFile()">
    </div>
    <input type="file" id="file" ref="file" @change="handleFileUpload()"/>
    <button class="import-button" @click="submitFile()">Импортировать</button>
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
    addFile() {
      this.$refs.file.click()
    },
    removeFile() {
      this.file = ''
    },
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
      this.file = ''
    }
  }
}
</script>

<style scoped>
input {
  position: absolute;
  top: -500px
}
.main-page {
  display: flex;
  align-items: center;
  justify-content: center;
}
.file-list {
  display: flex;
  flex-direction: row;
  margin: 0px 10px;
}
.remove-file {
  cursor: pointer;
  margin-left: 5px;
}
.add-button {
  height: 40px;
  width: 180px;
  margin: 0px 10px;
}
.import-button {
  background-color: #42b983;
  height: 40px;
  width: 180px;
  margin: 0px 10px;
}
</style>