namespace FrostweepGames.Plugins.GoogleCloud.TextToSpeech
{
    public class Enumerators
    {
        public enum GoogleCloudRequestType
        {
            GET_VOICES,
            SYNTHESIZE
        }

        public enum SsmlVoiceGender
        {
            SSML_VOICE_GENDER_UNSPECIFIED,
            MALE,
            FEMALE,
            NEUTRAL
        }

        public enum AudioEncoding
        {
            AUDIO_ENCODING_UNSPECIFIED,
            LINEAR16,
            MP3,
            OGG_OPUS
        }

        public enum LanguageCode
        {		
			ar_XA,
			bn_IN,
			cs_CZ,
			da_DK,
			nl_NL,
			en_AU,
			en_IN,
			en_GB,
			en_US,
			fil_PH,
			fi_FI,
			fr_CA,
			fr_FR,
			de_DE,
			el_GR,
			gu_IN,
			hi_IN,
			hu_HU,
			id_ID,
			it_IT,
			ja_JP,
			kn_IN,
			ko_KR,
			ml_IN,
			cmn_CN,
			nb_NO,
			pl_PL,
			pt_BR,
			pt_PT,
			ru_RU,
			sk_SK,
			es_ES,
			sv_SE,
			ta_IN,
			te_IN,
			th_TH,
			tr_TR,
			uk_UA,
			vi_VN		
        }

        public enum VoiceType
        {
            WAVENET,
            STANDARD
        }
    }
}