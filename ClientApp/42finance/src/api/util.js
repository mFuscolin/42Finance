import Axios from 'axios'

let util = {
  Axios: {
    Post: function (controller, dto) {
      return Axios.post(process.env.VUE_APP_ROOT_API + controller, dto).then(
        HandleResponse,
        HandleError
      )
    },
    Put: function (controller, id, dto) {
      if (!dto) {
        dto = {}
      }
      return Axios.put(
        process.env.VUE_APP_ROOT_API + controller + '/' + id,
        dto
      ).then(HandleResponse, HandleError)
    },
    Delete: function (controller, id) {
      return Axios.delete(process.env.VUE_APP_ROOT_API + controller + '/' + id)
        .then(HandleResponse, HandleError)
    },
    Get: function (controller, id) {
      if (id) {
        return Axios.get(
          process.env.VUE_APP_ROOT_API + controller + '/' + id
        ).then(HandleResponse, HandleError)
      } else {
        return Axios.get(
          process.env.VUE_APP_ROOT_API + controller
        ).then(HandleResponse, HandleError)
      }
    },
    GetAll: function (controller, dto) {
      return Axios.get(process.env.VUE_APP_ROOT_API + controller).then(HandleResponse, HandleError)
    },
    GetCrud: function (controller, methods) {
      var factory = {}
      if (!methods || (methods && methods.indexOf('get') >= 0)) {
        factory.Get = function (id) {
          return util.Axios.Get(controller, id)
        }
      }

      if (!methods || (methods && methods.indexOf('getall') >= 0)) {
        factory.GetAll = function (dto) {
          return util.Axios.GetAll(controller, dto)
        }
      }

      if (!methods || (methods && methods.indexOf('post') >= 0)) {
        factory.Post = function (dto) {
          return util.Axios.Post(controller, dto)
        }
      }

      if (!methods || (methods && methods.indexOf('put') >= 0)) {
        factory.Put = function (id, dto) {
          return util.Axios.Put(controller, id, dto)
        }
      }

      if (!methods || (methods && methods.indexOf('delete') >= 0)) {
        factory.Delete = function (id) {
          return util.Axios.Delete(controller, id)
        }
      }

      return factory
    }
  }
}

function HandleResponse (response) {
  let data = response.data
  if (typeof data === 'object' && data !== null) { data.statusCode = response.status }
  return data
}

function HandleError (error) {
  if (error) {
    if (error.response) {
      let data = error.response.data
      if (typeof data === 'object' && data !== null) { data.statusCode = error.status }
      return data
    }
    return error
  }
  return { error: 'Erro' }
}

export default util
